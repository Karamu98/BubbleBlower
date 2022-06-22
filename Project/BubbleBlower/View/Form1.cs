using System.Diagnostics;
using System.Reflection;
using MaterialSkin;
using MaterialSkin.Controls;
using BubbleBlower.View;

namespace BubbleBlower
{
    public partial class Form1 : MaterialForm
    {
        private List<ExtraSettingsElement> m_extraSettingsDisplay = new List<ExtraSettingsElement>();
        private bool m_changesMade = false;
        private Dictionary<MaterialTextBox2, string?> m_loadedTextValues = new Dictionary<MaterialTextBox2, string?>();
        private Dictionary<MaterialSwitch, bool?> m_loadedSwitchValues = new Dictionary<MaterialSwitch, bool?>();
        private string[] m_imageExtensions = new string[] { ".jpg", ".jpeg", ".bmp", ".png" };

        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager? materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey800, Primary.Grey900, Primary.Grey500, Accent.Red200, TextShade.WHITE);
            this.FormStyle = FormStyles.ActionBar_40;

            //RunTest(false);
            LoadSettings();
        }

        private void RunTest(bool batch)
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            if (batch)
            {
                string[] allFiles = Directory.GetFiles("./test/");
                List<BubbleConfig> configs = new List<BubbleConfig>(allFiles.Length);
                foreach (string file in allFiles)
                {
                    configs.Add(new BubbleConfig(file));
                }

                List<Task> allTasks = new List<Task>(configs.Count);
                foreach (BubbleConfig config in configs)
                {
                    Task newTask = Task.Factory.StartNew(async () => await config.BuildVPK(cts.Token));
                    allTasks.Add(newTask);
                }

                Task.WaitAll(allTasks.ToArray());
                MessageBox.Show("Done all");
            }
            else
            {
                BubbleConfig config = new BubbleConfig("./test/Mario & Luigi - Superstar Saga (USA).gba");
                Task newTask = Task.Factory.StartNew(async () => await config.BuildVPK(cts.Token));
                newTask.Wait();
                MessageBox.Show("Done");
            }
        }

        private void LoadSettings()
        {
            m_changesMade = false;

            m_loadedTextValues.Clear();
            // Set base settings
            PlatformSettings baseSettings = Properties.Settings.Default.GetPlatformSettings("default");
            SetTextField(ref m_psVitaROMPath, baseSettings.PSVitaROMDirectory);
            SetTextField(ref m_defaultIconPath, baseSettings.DefaultIconPath);
            SetTextField(ref m_defaultBackgroundPath, baseSettings.DefaultBackgroundPath);
            SetTextField(ref m_defaultStartupPath, baseSettings.DefaultStartupPath);
            SetTextField(ref m_iconHTMLID, baseSettings.IconHTMLResource);
            SetTextField(ref m_bgHTMLID, baseSettings.BackgroundHTMLResource);
            SetTextField(ref m_startupHTMLID, baseSettings.StartupHTMLResource);

            m_loadedSwitchValues.Clear();
            SetSwitchField(ref m_alwaysDefaultIcon, baseSettings.AlwaysDefaultIcon);
            SetSwitchField(ref m_alwaysDefaultBackground, baseSettings.AlwaysDefaultBackground);
            SetSwitchField(ref m_alwaysDefaultStartup, baseSettings.AlwaysDefaultStart);
            SetSwitchField(ref m_cleanVisualGameName, baseSettings.SanitiseGameName);

            // This is horrible, pls use WFP in the future bc apparently this is way faster there
            // TODO: Maybe make a caching system for created ExtraSettingElements
            ExtraSettingsScroll.Controls.Clear();
            m_extraSettingsDisplay = new List<ExtraSettingsElement>(Properties.Settings.Default.PlatformSettings.Count);
            foreach (var kvp in Properties.Settings.Default.PlatformSettings)
            {
                ExtraSettingsElement newElement = new ExtraSettingsElement();
                newElement.Collapse = true;
                newElement.Dock = DockStyle.Top;
                newElement.SetData(kvp.Key, kvp.Value);
                m_extraSettingsDisplay.Add(newElement);
                newElement.ExtraSettingsChanged += ExtraSettingsChanged;
                ExtraSettingsScroll.Controls.Add(newElement);
            }
        }

        private void SetTextField(ref MaterialTextBox2 target, string? value)
        {
            m_loadedTextValues.Add(target, value);

            if (value == null)
            {
                target.Text = "";
                return;
            }
            target.Text = value;
        }

        private void SetSwitchField(ref MaterialSwitch target, bool? value)
        {
            m_loadedSwitchValues.Add(target, value);

            if (value == null)
            {
                target.CheckState = CheckState.Indeterminate;
                return;
            }
            target.Checked = value.Value;
        }

        private bool ValidateTextField(ref MaterialTextBox2 target, Func<string, bool> validations)
        {
            bool isValid = validations(target.Text);
            target.SetErrorState(!isValid);
            target.ShowAssistiveText = !isValid;
            return isValid;
        }

        private bool IsImage(string file)
        {
            foreach (var ext in m_imageExtensions)
            {
                if(file.EndsWith(ext, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void m_saveChangesButton_Click(object sender, EventArgs e)
        {
            /// VALIDATION
            bool baseValid = true;
            baseValid &= ValidateTextField(ref m_psVitaROMPath, (val) => val.Contains("0:"));
            baseValid &= ValidateTextField(ref m_defaultIconPath, (val) => IsImage(val));
            baseValid &= ValidateTextField(ref m_defaultBackgroundPath, (val) => IsImage(val));
            baseValid &= ValidateTextField(ref m_defaultStartupPath, (val) => IsImage(val));
            if(!baseValid)
            {
                return;
            }

            HashSet<string> nameTest = new HashSet<string>(m_extraSettingsDisplay.Count);
            foreach(ExtraSettingsElement? ele in m_extraSettingsDisplay)
            {
                if(!ele.IsValid())
                {
                    MessageBox.Show($"Error ({ele.TargetPlatformName}): Required platform name and at least one extension");
                    return;
                }

                if(nameTest.Contains(ele.TargetPlatformName))
                {
                    MessageBox.Show($"Error: Multiple entries for ({ele.TargetPlatformName})");
                    return;
                }

                nameTest.Add(ele.TargetPlatformName);
            }

            /// SAVING
            // Apply and get all data to extra settings
            Dictionary<string, PlatformSettings> newSettings = new Dictionary<string, PlatformSettings>(m_extraSettingsDisplay.Count);
            foreach (ExtraSettingsElement ele in m_extraSettingsDisplay)
            {
                ele.ApplyAllChanges();
                KeyValuePair<string, PlatformSettings> cur = ele.GetData();
                newSettings.Add(cur.Key, cur.Value);
            }

            // Get all base settings
            PlatformSettings baseSettings = new PlatformSettings();
            baseSettings.PSVitaROMDirectory = m_psVitaROMPath.Text;
            baseSettings.DefaultIconPath = m_defaultIconPath.Text;
            baseSettings.DefaultBackgroundPath = m_defaultBackgroundPath.Text;
            baseSettings.DefaultStartupPath = m_defaultStartupPath.Text;
            baseSettings.IconHTMLResource = m_iconHTMLID.Text;
            baseSettings.BackgroundHTMLResource = m_bgHTMLID.Text;
            baseSettings.StartupHTMLResource = m_startupHTMLID.Text;
            baseSettings.AlwaysDefaultIcon = m_alwaysDefaultIcon.Checked;
            baseSettings.AlwaysDefaultBackground = m_alwaysDefaultBackground.Checked;
            baseSettings.AlwaysDefaultStart = m_alwaysDefaultStartup.Checked;

            // Set data for saving and save
            Properties.Settings.Default.BaseSettings = baseSettings;
            Properties.Settings.Default.PlatformSettings = newSettings;
            Properties.Settings.Default.Save();

            LoadSettings();
        }

        private void AnyItemChanged(object? sender, EventArgs e)
        {
            m_changesMade = false;
            if (sender == null)
            {
                foreach (var ele in m_extraSettingsDisplay)
                {
                    if (ele.DataChanged)
                    {
                        m_changesMade = true;
                        break;
                    }
                }
            }
            else
            {
                foreach(var ele in m_loadedTextValues)
                {
                    string? startVal = ele.Value;
                    if(startVal == null)
                    {
                        m_changesMade = ele.Key.Text != "";
                    }
                    else
                    {
                        m_changesMade = ele.Key.Text != startVal;
                    }
                    if (m_changesMade)
                    {
                        break;
                    }
                }

                foreach (var ele in m_loadedSwitchValues)
                {
                    bool? startVal = ele.Value;
                    if (startVal == null)
                    {
                        m_changesMade = ele.Key.Text != "";
                    }
                    else
                    {
                        m_changesMade = ele.Key.Checked != startVal;
                    }
                    if (m_changesMade)
                    {
                        break;
                    }
                }
            }

            m_saveChangesButton.Enabled = m_changesMade;
        }

        private void ExtraSettingsChanged(object? sender, EventArgs e)
        {
            AnyItemChanged(null, e);
        }
    }
}
