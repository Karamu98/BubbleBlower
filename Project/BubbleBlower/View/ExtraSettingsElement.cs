using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace BubbleBlower.View
{
    public partial class ExtraSettingsElement : UserControl
    {
        [Browsable(true)]
        [Category("Property Changed")]
        [Description("Invoked when any changes are made")]
        public event EventHandler? ExtraSettingsChanged;

        public bool Collapse { get { return baseExpansionPanel.Collapse; } set { baseExpansionPanel.Collapse = value; } }
        const int CollapsedHeight = 56;

        public string TargetPlatformName { get; private set; } = "";
        PlatformSettings? m_data;
        public bool DataChanged { get; private set; } = false;

        // For changed tracking
        private NullableTextField[] m_nullableTextFields;
        private string m_platformStartValue = "";
        private string m_extensionsStartValue = "";


        public ExtraSettingsElement()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(this.Size.Width, baseExpansionPanel.Collapse ? CollapsedHeight : baseExpansionPanel.ExpandHeight);
            m_nullableTextFields = new NullableTextField[]
                {
                    m_optionalPSROMPath,
                    m_optionalDefaultIcon,
                    m_optionalDefaultBG,
                    m_optionalDefaultStartup,
                    m_optionalIconHTMLID,
                    m_optionalBGHTMLID,
                    m_optionalStartupHTMLID
                };

        }

        private string ExtensionsToString(string[]? data)
        {
            if(data == null)
            {
                return "";
            }
            return String.Join(", ", data);
        }

        private string[] StringToExtensions(string data)
        {
            data = data.Replace(" ", "");
            return data.Split(',');
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(m_platformName.Text) && m_extensions.Text.Contains(".");
        }

        public void SetData(string platformName, PlatformSettings data)
        {
            m_data = data;

            TargetPlatformName = platformName;
            m_platformStartValue = platformName;
            baseExpansionPanel.Description = platformName;

            m_platformName.Text = platformName;
            string extensions = ExtensionsToString(m_data.Extensions);
            m_extensionsStartValue = extensions;
            m_extensions.Text = extensions;

            m_optionalPSROMPath.SetData(m_data.PSVitaROMDirectory);
            m_optionalDefaultIcon.SetData(m_data.DefaultIconPath);
            m_optionalDefaultBG.SetData(m_data.DefaultBackgroundPath);
            m_optionalDefaultStartup.SetData(m_data.DefaultStartupPath);

            m_optionalIconHTMLID.SetData(m_data.IconHTMLResource);
            m_optionalBGHTMLID.SetData(m_data.BackgroundHTMLResource);
            m_optionalStartupHTMLID.SetData(m_data.StartupHTMLResource);

            DataChanged = false;
        }

        public KeyValuePair<string, PlatformSettings> GetData()
        {
            return new KeyValuePair<string, PlatformSettings>(TargetPlatformName, m_data);
        }

        public void ApplyAllChanges()
        {
            TargetPlatformName = m_platformName.Text;
            m_data.Extensions = StringToExtensions(m_extensions.Text);

            m_data.PSVitaROMDirectory = m_optionalPSROMPath.GetData();
            m_data.DefaultIconPath = m_optionalDefaultIcon.GetData();
            m_data.DefaultBackgroundPath = m_optionalDefaultBG.GetData();
            m_data.DefaultStartupPath = m_optionalDefaultStartup.GetData();

            m_data.IconHTMLResource = m_optionalIconHTMLID.GetData();
            m_data.BackgroundHTMLResource = m_optionalBGHTMLID.GetData();
            m_data.StartupHTMLResource = m_optionalStartupHTMLID.GetData();

            SetData(TargetPlatformName, m_data);
        }

        private void materialExpansionPanel1_PanelExpand(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(this.Size.Width, baseExpansionPanel.ExpandHeight);
        }

        private void materialExpansionPanel1_PanelCollapse(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(this.Size.Width, CollapsedHeight);
        }

        private void materialExpansionPanel1_SaveClick(object sender, EventArgs e)
        {
            ApplyAllChanges();
        }

        private void materialExpansionPanel1_CancelClick(object sender, EventArgs e)
        {
            SetData(m_platformName.Text, m_data);
        }

        private void OnAnyTextChanged(object sender, EventArgs e)
        {
            DataChanged = false;

            NullableTextField? textField = sender as NullableTextField;
            if (textField != null)
            {
                DataChanged = textField.HasChanged;
            }

            if(m_platformStartValue != m_platformName.Text || m_extensionsStartValue != m_extensions.Text)
            {
                DataChanged = true;
            }

            baseExpansionPanel.ValidationButtonEnable = DataChanged;

            ExtraSettingsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
