using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using BubbleBlower.Properties;

namespace BubbleBlower
{
    internal class BubbleConfig
    {
        public BubbleConfig(string romPath)
        {
            InitialiseUsingSettings(romPath);
        }

        public static readonly string BGIMGFILE = "bg.png";
        public static readonly string ICON0IMGFILE = "icon0.png";
        public static readonly string STARTUPIMGFILE = "startup.png";
        public static readonly string ROMPATHFILE = "rom.txt";
        public static readonly string COREPATHFILE = "core.txt";
        public static readonly string PARAMSPATHFILE = "param.sfo";
        public static readonly string TEMPLATEPATHFILE = "template.xml";

        // VPK data
        public string GameDisplayName = "RetroGame";
        public string ROMID = "";
        public string? ROMFullPath;
        public string? CoreConfig;
        public bool IsN64 = false;
        // public string? TemplatePath; // TODO: Allow templates styles

        // Image data
        ImageSource? m_iconSource;
        ImageSource? m_backgroundSource;
        ImageSource? m_startupSource;

        public string ROMPlatform = "default";


        public string WorkingDirectory 
        {
            get
            {
                return Path.Combine("Build", GetFSSafeName());
            }
        }

        public string VPKsOutDirectory
        {
            get
            {
                return ".\\Build";
            }
        }


        public async Task BuildVPK(CancellationToken token, bool copyOutToRoot = true)
        {
            await GenerateBuildFiles(token);
            if (!IsValidForBuild())
            {
                return;
            }

            string outputPath = $"{GetFSSafeName()}.vpk";
            string confParams = $"-s TITLE_ID={ROMID} \"{GameDisplayName}\" {PARAMSPATHFILE}";
            Process preprocess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Program.MksfoexPath,
                    Arguments = confParams,
                    WorkingDirectory = WorkingDirectory,
                }
            };
            preprocess.Start();
            preprocess.WaitForExit();

            string extraParams;
            if (!IsN64)
            {
                extraParams = $"-a {COREPATHFILE}=core.txt -a {ROMPATHFILE}=rom.txt";
            }
            else
            {
                extraParams = $"-a {ROMPATHFILE}=args.txt";
            }

            confParams = $"-s {PARAMSPATHFILE} -b {Program.EBootBinaryRelativePath} \"{outputPath}\" -a {ICON0IMGFILE}=sce_sys/icon0.png -a {BGIMGFILE}=sce_sys/livearea/contents/bg.png -a {STARTUPIMGFILE}=sce_sys/livearea/contents/startup.png -a {TEMPLATEPATHFILE}=sce_sys/livearea/contents/template.xml {extraParams}";
            Process buildProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Program.VitaPackPath,
                    Arguments = confParams,
                    WorkingDirectory = WorkingDirectory,
                }
            };
            buildProcess.Start();
            buildProcess.WaitForExit();

            string finalOutPath = Path.Combine(WorkingDirectory, outputPath);
            if (copyOutToRoot && File.Exists(finalOutPath))
            {
                File.Copy(finalOutPath, Path.Combine(VPKsOutDirectory, outputPath), true);
            }
        }

        public void InitialiseUsingSettings(string romPath)
        {
            string romFile = Path.GetFileName(romPath);
            ROMPlatform = Settings.Default.TryGetPlatformFromExtension(romPath);
            ROMFullPath = $"{Settings.Default.GetSetting(item => item.PSVitaROMDirectory, ROMPlatform)}{romFile}";
            IsN64 = romFile.EndsWith(".z64");
            CoreConfig = Settings.Default.GetSetting(item => item.Core, ROMPlatform);
            SetCleanGameName(romFile);
            GenerateUniqueROMID();

            SetupImageSource(ref m_iconSource, $"{WorkingDirectory}/images/icon0.png", item => item.DefaultIconPath, item => item.AlwaysDefaultIcon, item => item.IconHTMLResource);
            SetupImageSource(ref m_backgroundSource, $"{WorkingDirectory}/images/bg.png", item => item.DefaultBackgroundPath, item => item.AlwaysDefaultBackground, item => item.BackgroundHTMLResource);
            SetupImageSource(ref m_startupSource, $"{WorkingDirectory}/images/startup.png", item => item.DefaultStartupPath, item => item.AlwaysDefaultStart, item => item.StartupHTMLResource);


            if (!Directory.Exists(WorkingDirectory))
            {
                Directory.CreateDirectory(WorkingDirectory);
            }
        }

        public async Task RefreshImageSourcesAsync(CancellationToken token)
        {
            if(m_iconSource == null || m_backgroundSource == null || m_startupSource == null)
            {
                return;
            }

            bool shouldTryDownload = ROMPlatform != null && ROMPlatform != "default";
            await m_iconSource.FetchImage(shouldTryDownload, token);
            await m_backgroundSource.FetchImage(shouldTryDownload, token);
            await m_startupSource.FetchImage(shouldTryDownload, token);
        }

        private void SetupImageSource(ref ImageSource? target, string filePath, Func<PlatformSettings, string> defaultPath, Func<PlatformSettings, bool?> alwaysDefault, Func<PlatformSettings, string> hTMLResource)
        {
            target = new ImageSource();
            target.DefaultFile = Settings.Default.GetSetting(defaultPath, ROMPlatform);
            target.ImageDestination = filePath;
            bool? alwaysIcon = Settings.Default.GetSetting(alwaysDefault, ROMPlatform);
            if (!alwaysIcon.HasValue || alwaysIcon.Value == false)
            {
                string res = Settings.Default.GetSetting(hTMLResource, ROMPlatform);
                string? targetURL = ImageScraper_libretro.GetImageURLFromGame(ROMFullPath, ROMPlatform, res);
                if (targetURL != null)
                {
                    target.ExternalURL = targetURL;
                }
            }
        }

        private void SetCleanGameName(string filepath)
        {
            string final = Path.GetFileNameWithoutExtension(filepath);

            bool? cleanName = Settings.Default.GetSetting(item => item.SanitiseGameName, ROMPlatform);
            if (cleanName != null && cleanName.Value == false)
            {
                GameDisplayName = final;
                return;
            }

            char[] badChars = { '(', ')', '[', ']' };
            foreach(char ch in badChars)
            {
                final.Replace(ch, ' ');
            }
            GameDisplayName = final;
        }

        private void GenerateUniqueROMID()
        {
            // 9 characters A-Z-0-9
            using (HashAlgorithm sha1 = SHA1.Create())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(GameDisplayName + ROMFullPath));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }

                ROMID = sb.ToString();
                ROMID = ROMID[..9]; // Reduce to 9 characters
            }
        }

        private string GetFSSafeName()
        {
            string fileName = GameDisplayName;
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                fileName = fileName.Replace(c, '-');
            }
            fileName.Replace(" ", "");
            return fileName;
        }

        private async Task GenerateBuildFiles(CancellationToken token)
        {
            if (m_iconSource != null && m_backgroundSource != null && m_startupSource != null)
            {
                await RefreshImageSourcesAsync(token);

                // Process over linked images and output into working directory
                m_iconSource.CopyTo(Path.Combine(WorkingDirectory, ICON0IMGFILE));
                m_backgroundSource.CopyTo(Path.Combine(WorkingDirectory, BGIMGFILE));
                m_startupSource.CopyTo(Path.Combine(WorkingDirectory, STARTUPIMGFILE));
            }

            if (!IsN64 && CoreConfig != null)
            {
                File.WriteAllText(Path.Combine(WorkingDirectory, COREPATHFILE), CoreConfig);
            }

            if(ROMFullPath != null)
            {
                File.WriteAllText(Path.Combine(WorkingDirectory, ROMPATHFILE), ROMFullPath);
            }

            File.Copy(Program.SFOFilePath, Path.Combine(WorkingDirectory, PARAMSPATHFILE), true);
            File.Copy(Program.TemplateFilePath, Path.Combine(WorkingDirectory, TEMPLATEPATHFILE), true);
        }

        private bool IsValidForBuild()
        {
            if(ROMID.Length != 9 || !Regex.IsMatch(ROMID, "^[a-zA-Z0-9]*$"))
            {
                MessageBox.Show($"BubbleConfig {GameDisplayName}: Please enter or generate a 9 character alphanumeric ID");
                return false;
            }

            if (!Directory.Exists(WorkingDirectory))
            {
                MessageBox.Show($"BubbleConfig {GameDisplayName} has no working directory.");
                return false;
            }

            string[] requiredFiles = IsN64 ? new[] { BGIMGFILE, ICON0IMGFILE, STARTUPIMGFILE, ROMPATHFILE } : new[] { BGIMGFILE, ICON0IMGFILE, STARTUPIMGFILE, ROMPATHFILE, COREPATHFILE };
            List<string> missing = new List<string>(requiredFiles.Length);
            foreach (string requiredFile in requiredFiles)
            {
                if (!File.Exists($"{Path.Combine(WorkingDirectory, requiredFile)}"))
                {
                    missing.Add(requiredFile);
                }
            }
            if(missing.Count > 0)
            {
                string missingInfo = $"BubbleConfig {GameDisplayName} is missing files:";
                foreach(string missingFile in missing)
                {
                    missingInfo += $"\n{missingFile}";
                }
                MessageBox.Show(missingInfo);
                return false;
            }

            return true;
        }
    }
}
