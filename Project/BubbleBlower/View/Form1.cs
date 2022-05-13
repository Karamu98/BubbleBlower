using System.Diagnostics;
using System.Reflection;
using MaterialSkin;
using MaterialSkin.Controls;
using BubbleBlower.View;

namespace BubbleBlower
{
    public partial class Form1 : MaterialForm
    {
        private List<ExtraSettingsElement> m_extraSettingsDisplay;
        private bool m_changesMade = false;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
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

            // Set base settings
            PlatformSettings baseSettings = Properties.Settings.Default.GetPlatformSettings("default");
            SetTextField(ref m_psVitaROMPath, baseSettings.PSVitaROMDirectory);
            SetTextField(ref m_defaultIconPath, baseSettings.DefaultIconPath);
            SetTextField(ref m_defaultBackgroundPath, baseSettings.DefaultBackgroundPath);
            SetTextField(ref m_defaultStartupPath, baseSettings.DefaultStartupPath);
            SetTextField(ref m_iconHTMLID, baseSettings.IconHTMLResource);
            SetTextField(ref m_bgHTMLID, baseSettings.BackgroundHTMLResource);
            SetTextField(ref m_startupHTMLID, baseSettings.StartupHTMLResource);

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

        private void ExtraSettingsChanged(object? sender, EventArgs e)
        {
            m_changesMade = false;

            foreach (var ele in m_extraSettingsDisplay)
            {
                if(ele.DataChanged)
                {
                    m_changesMade = true;
                    break;
                }
            }

            m_saveChangesButton.Enabled = m_changesMade;
        }

        private void SetTextField(ref MaterialTextBox2 target, string? value)
        {
            if(value == null)
            {
                target.Text = "";
                return;
            }
            target.Text = value;
        }

        private void SetSwitchField(ref MaterialSwitch target, bool? value)
        {
            if (value == null)
            {
                target.CheckState = CheckState.Indeterminate;
                return;
            }
            target.Checked = value.Value;
        }

        private void m_saveChangesButton_Click(object sender, EventArgs e)
        {
            // Validate base

            // Validate
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

            Dictionary<string, PlatformSettings> newSettings = new Dictionary<string, PlatformSettings>(m_extraSettingsDisplay.Count);
            foreach (ExtraSettingsElement ele in m_extraSettingsDisplay)
            {
                ele.ApplyAllChanges();
                KeyValuePair<string, PlatformSettings> cur = ele.GetData();
                newSettings.Add(cur.Key, cur.Value);
            }
        }
    }
}
