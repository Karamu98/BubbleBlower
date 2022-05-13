using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BubbleBlower.Properties
{
    [System.Serializable]
    internal class Settings
    {
        public PlatformSettings BaseSettings;
        public Dictionary<string, PlatformSettings> PlatformSettings;

        public T GetSetting<T>(Func<PlatformSettings, T> item, string platformName)
        {
            PlatformSettings settings = GetPlatformSettings(platformName);
            return item(settings);
        }

        public PlatformSettings GetPlatformSettings(string platformName)
        {
            if (platformName == "default")
            {
                return BaseSettings;
            }

            if (PlatformSettings.TryGetValue(platformName, out PlatformSettings? setting))
            {
                if (setting != null)
                {
                    return setting;
                }
            }

            return BaseSettings;
        }

        public string TryGetPlatformFromExtension(string path)
        {
            foreach (var kvp in Default.PlatformSettings)
            {
                foreach (var ext in kvp.Value.Extensions)
                {
                    if (path.EndsWith(ext))
                    {
                        return kvp.Key;
                    }
                }
            }
            return "default";
        }

        private static Settings DefaultSettings()
        {
            return new Settings
            {
                BaseSettings = new PlatformSettings()
                {
                    PSVitaROMDirectory = "ux0:ROMs/",
                    SanitiseGameName = true,
                    DefaultIconPath = "tools/icon0.png",
                    DefaultBackgroundPath = "tools/bg.png",
                    DefaultStartupPath = "tools/startup.png",
                    AlwaysDefaultIcon = true,
                    AlwaysDefaultBackground = true,
                    AlwaysDefaultStart = true,
                    IconHTMLResource = ImageScraper_libretro.Boxart,
                    BackgroundHTMLResource = ImageScraper_libretro.Screenshot,
                },
                PlatformSettings = new Dictionary<string, PlatformSettings>
                {
                    { 
                        "Nintendo - Game Boy Advance", new PlatformSettings
                        {
                            Extensions = new[]{".gba"},
                            PSVitaROMDirectory = "ux0:ROMs/GBA/",
                            DefaultStartupPath = "tools/GBA/startup.png",
                            Core = "gpsp_libretro.self",
                            AlwaysDefaultIcon = false,
                            AlwaysDefaultBackground = false,
                        }
                    },
                    {
                        "Nintendo - Game Boy Color", new PlatformSettings
                        {
                            Extensions = new[]{".gbc"},
                            PSVitaROMDirectory = "ux0:ROMs/GBC/",
                            DefaultStartupPath = "tools/GBC/startup.png",
                            Core = "gambatte_libretro.self",
                            AlwaysDefaultIcon = false,
                            AlwaysDefaultBackground = false,
                        }
                    },
                    {
                        "Nintendo - Game Boy", new PlatformSettings
                        {
                            Extensions = new[]{".gb"},
                            PSVitaROMDirectory = "ux0:ROMs/GB/",
                            DefaultStartupPath = "tools/GB/startup.png",
                            Core = "gambatte_libretro.self",
                            AlwaysDefaultIcon = false,
                            AlwaysDefaultBackground = false,
                        }
                    },
                    {
                        "Nintendo - Nintendo 64", new PlatformSettings
                        {
                            Extensions = new[]{".z64"},
                            PSVitaROMDirectory = "ux0:ROMs/N64/",
                            DefaultStartupPath = "tools/N64/startup.png",
                            AlwaysDefaultIcon = false,
                            AlwaysDefaultBackground = false,
                        }
                    },
                    {
                        "Nintendo - Super Nintendo Entertainment System", new PlatformSettings
                        {
                            Extensions = new[]{".sfc"},
                            PSVitaROMDirectory = "ux0:ROMs/SNES/",
                            DefaultStartupPath = "tools/SNES/startup.png",
                            Core = "snes9x2005_plus_libretro.self",
                            AlwaysDefaultIcon = false,
                            AlwaysDefaultBackground = false,
                        }
                    },
                    {
                        "Nintendo - Nintendo Entertainment System", new PlatformSettings
                        {
                            Extensions = new[]{".nes"},
                            PSVitaROMDirectory = "ux0:ROMs/NES/",
                            DefaultStartupPath = "tools/NES/startup.png",
                            Core = "fceumm_libretro.self",
                            AlwaysDefaultIcon = false,
                            AlwaysDefaultBackground = false,
                        }
                    },
                }
            };
        }

        public void Save()
        {
            _defaultInstance = this;
            var str = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(DefaultSaveFile, str);
        }

        public static Settings? Default
        {
            get
            {
                if (_defaultInstance != null)
                {
                    return _defaultInstance;
                }

                Settings settings;
                if (File.Exists(DefaultSaveFile) == false)
                {
                    settings = DefaultSettings();
                }
                else
                {
                    string? str = File.ReadAllText(DefaultSaveFile);
                    settings = JsonConvert.DeserializeObject<Settings>(str);
                }
                _defaultInstance = settings;
                return settings;
            }
        }

        private static string DefaultSaveFile => Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "BubbleBlower.json");
        private static Settings? _defaultInstance = null;
    }
}
