namespace BubbleBlower.View
{
    partial class ExtraSettingsElement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseExpansionPanel = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cleanVisualGameName = new MaterialSkin.Controls.MaterialSwitch();
            this.m_alwaysDefaultStartup = new MaterialSkin.Controls.MaterialSwitch();
            this.m_alwaysDefaultIcon = new MaterialSkin.Controls.MaterialSwitch();
            this.m_alwaysDefaultBackground = new MaterialSkin.Controls.MaterialSwitch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_optionalStartupHTMLID = new BubbleBlower.View.NullableTextField();
            this.m_optionalBGHTMLID = new BubbleBlower.View.NullableTextField();
            this.m_optionalIconHTMLID = new BubbleBlower.View.NullableTextField();
            this.m_optionalDefaultStartup = new BubbleBlower.View.NullableTextField();
            this.m_optionalDefaultBG = new BubbleBlower.View.NullableTextField();
            this.m_optionalDefaultIcon = new BubbleBlower.View.NullableTextField();
            this.m_optionalPSROMPath = new BubbleBlower.View.NullableTextField();
            this.m_extensions = new MaterialSkin.Controls.MaterialTextBox2();
            this.m_platformName = new MaterialSkin.Controls.MaterialTextBox2();
            this.baseExpansionPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseExpansionPanel
            // 
            this.baseExpansionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.baseExpansionPanel.Controls.Add(this.panel3);
            this.baseExpansionPanel.Depth = 0;
            this.baseExpansionPanel.Description = "";
            this.baseExpansionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseExpansionPanel.ExpandHeight = 644;
            this.baseExpansionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.baseExpansionPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.baseExpansionPanel.Location = new System.Drawing.Point(3, 4);
            this.baseExpansionPanel.Margin = new System.Windows.Forms.Padding(16);
            this.baseExpansionPanel.MouseState = MaterialSkin.MouseState.HOVER;
            this.baseExpansionPanel.Name = "baseExpansionPanel";
            this.baseExpansionPanel.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.baseExpansionPanel.Size = new System.Drawing.Size(672, 636);
            this.baseExpansionPanel.TabIndex = 0;
            this.baseExpansionPanel.Title = "Platform";
            this.baseExpansionPanel.ValidationButtonText = "APPLY";
            this.baseExpansionPanel.SaveClick += new System.EventHandler(this.materialExpansionPanel1_SaveClick);
            this.baseExpansionPanel.CancelClick += new System.EventHandler(this.materialExpansionPanel1_CancelClick);
            this.baseExpansionPanel.PanelCollapse += new System.EventHandler(this.materialExpansionPanel1_PanelCollapse);
            this.baseExpansionPanel.PanelExpand += new System.EventHandler(this.materialExpansionPanel1_PanelExpand);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(24, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 496);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_cleanVisualGameName);
            this.panel2.Controls.Add(this.m_alwaysDefaultStartup);
            this.panel2.Controls.Add(this.m_alwaysDefaultIcon);
            this.panel2.Controls.Add(this.m_alwaysDefaultBackground);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(348, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 496);
            this.panel2.TabIndex = 16;
            // 
            // m_cleanVisualGameName
            // 
            this.m_cleanVisualGameName.AutoSize = true;
            this.m_cleanVisualGameName.Depth = 0;
            this.m_cleanVisualGameName.Location = new System.Drawing.Point(6, 23);
            this.m_cleanVisualGameName.Margin = new System.Windows.Forms.Padding(0);
            this.m_cleanVisualGameName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_cleanVisualGameName.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_cleanVisualGameName.Name = "m_cleanVisualGameName";
            this.m_cleanVisualGameName.Ripple = true;
            this.m_cleanVisualGameName.Size = new System.Drawing.Size(217, 37);
            this.m_cleanVisualGameName.TabIndex = 12;
            this.m_cleanVisualGameName.Text = "Sanitise Visual Names";
            this.m_cleanVisualGameName.UseVisualStyleBackColor = true;
            // 
            // m_alwaysDefaultStartup
            // 
            this.m_alwaysDefaultStartup.AutoSize = true;
            this.m_alwaysDefaultStartup.Depth = 0;
            this.m_alwaysDefaultStartup.Location = new System.Drawing.Point(6, 185);
            this.m_alwaysDefaultStartup.Margin = new System.Windows.Forms.Padding(0);
            this.m_alwaysDefaultStartup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_alwaysDefaultStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_alwaysDefaultStartup.Name = "m_alwaysDefaultStartup";
            this.m_alwaysDefaultStartup.Ripple = true;
            this.m_alwaysDefaultStartup.Size = new System.Drawing.Size(221, 37);
            this.m_alwaysDefaultStartup.TabIndex = 15;
            this.m_alwaysDefaultStartup.Text = "Always Default Startup";
            this.m_alwaysDefaultStartup.UseVisualStyleBackColor = true;
            // 
            // m_alwaysDefaultIcon
            // 
            this.m_alwaysDefaultIcon.AutoSize = true;
            this.m_alwaysDefaultIcon.Depth = 0;
            this.m_alwaysDefaultIcon.Location = new System.Drawing.Point(6, 73);
            this.m_alwaysDefaultIcon.Margin = new System.Windows.Forms.Padding(0);
            this.m_alwaysDefaultIcon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_alwaysDefaultIcon.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_alwaysDefaultIcon.Name = "m_alwaysDefaultIcon";
            this.m_alwaysDefaultIcon.Ripple = true;
            this.m_alwaysDefaultIcon.Size = new System.Drawing.Size(199, 37);
            this.m_alwaysDefaultIcon.TabIndex = 13;
            this.m_alwaysDefaultIcon.Text = "Always Default Icon";
            this.m_alwaysDefaultIcon.UseVisualStyleBackColor = true;
            // 
            // m_alwaysDefaultBackground
            // 
            this.m_alwaysDefaultBackground.AutoSize = true;
            this.m_alwaysDefaultBackground.Depth = 0;
            this.m_alwaysDefaultBackground.Location = new System.Drawing.Point(6, 129);
            this.m_alwaysDefaultBackground.Margin = new System.Windows.Forms.Padding(0);
            this.m_alwaysDefaultBackground.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_alwaysDefaultBackground.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_alwaysDefaultBackground.Name = "m_alwaysDefaultBackground";
            this.m_alwaysDefaultBackground.Ripple = true;
            this.m_alwaysDefaultBackground.Size = new System.Drawing.Size(254, 37);
            this.m_alwaysDefaultBackground.TabIndex = 14;
            this.m_alwaysDefaultBackground.Text = "Always Default Background";
            this.m_alwaysDefaultBackground.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_optionalStartupHTMLID);
            this.panel1.Controls.Add(this.m_optionalBGHTMLID);
            this.panel1.Controls.Add(this.m_optionalIconHTMLID);
            this.panel1.Controls.Add(this.m_optionalDefaultStartup);
            this.panel1.Controls.Add(this.m_optionalDefaultBG);
            this.panel1.Controls.Add(this.m_optionalDefaultIcon);
            this.panel1.Controls.Add(this.m_optionalPSROMPath);
            this.panel1.Controls.Add(this.m_extensions);
            this.panel1.Controls.Add(this.m_platformName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.panel1.Size = new System.Drawing.Size(348, 496);
            this.panel1.TabIndex = 11;
            // 
            // m_optionalStartupHTMLID
            // 
            this.m_optionalStartupHTMLID.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_optionalStartupHTMLID.Hint = "Startup identifier";
            this.m_optionalStartupHTMLID.Location = new System.Drawing.Point(0, 438);
            this.m_optionalStartupHTMLID.MinimumSize = new System.Drawing.Size(0, 57);
            this.m_optionalStartupHTMLID.Name = "m_optionalStartupHTMLID";
            this.m_optionalStartupHTMLID.Size = new System.Drawing.Size(332, 57);
            this.m_optionalStartupHTMLID.TabIndex = 19;
            this.m_optionalStartupHTMLID.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // m_optionalBGHTMLID
            // 
            this.m_optionalBGHTMLID.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_optionalBGHTMLID.Hint = "Background Identifier";
            this.m_optionalBGHTMLID.Location = new System.Drawing.Point(0, 381);
            this.m_optionalBGHTMLID.MinimumSize = new System.Drawing.Size(0, 57);
            this.m_optionalBGHTMLID.Name = "m_optionalBGHTMLID";
            this.m_optionalBGHTMLID.Size = new System.Drawing.Size(332, 57);
            this.m_optionalBGHTMLID.TabIndex = 18;
            this.m_optionalBGHTMLID.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // m_optionalIconHTMLID
            // 
            this.m_optionalIconHTMLID.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_optionalIconHTMLID.Hint = "Icon identifier";
            this.m_optionalIconHTMLID.Location = new System.Drawing.Point(0, 324);
            this.m_optionalIconHTMLID.MinimumSize = new System.Drawing.Size(0, 57);
            this.m_optionalIconHTMLID.Name = "m_optionalIconHTMLID";
            this.m_optionalIconHTMLID.Size = new System.Drawing.Size(332, 57);
            this.m_optionalIconHTMLID.TabIndex = 17;
            this.m_optionalIconHTMLID.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // m_optionalDefaultStartup
            // 
            this.m_optionalDefaultStartup.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_optionalDefaultStartup.Hint = "Default startup";
            this.m_optionalDefaultStartup.Location = new System.Drawing.Point(0, 267);
            this.m_optionalDefaultStartup.MinimumSize = new System.Drawing.Size(0, 57);
            this.m_optionalDefaultStartup.Name = "m_optionalDefaultStartup";
            this.m_optionalDefaultStartup.Size = new System.Drawing.Size(332, 57);
            this.m_optionalDefaultStartup.TabIndex = 16;
            this.m_optionalDefaultStartup.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // m_optionalDefaultBG
            // 
            this.m_optionalDefaultBG.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_optionalDefaultBG.Hint = "Default background";
            this.m_optionalDefaultBG.Location = new System.Drawing.Point(0, 210);
            this.m_optionalDefaultBG.MinimumSize = new System.Drawing.Size(0, 57);
            this.m_optionalDefaultBG.Name = "m_optionalDefaultBG";
            this.m_optionalDefaultBG.Size = new System.Drawing.Size(332, 57);
            this.m_optionalDefaultBG.TabIndex = 15;
            this.m_optionalDefaultBG.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // m_optionalDefaultIcon
            // 
            this.m_optionalDefaultIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_optionalDefaultIcon.Hint = "Default icon";
            this.m_optionalDefaultIcon.Location = new System.Drawing.Point(0, 153);
            this.m_optionalDefaultIcon.MinimumSize = new System.Drawing.Size(0, 57);
            this.m_optionalDefaultIcon.Name = "m_optionalDefaultIcon";
            this.m_optionalDefaultIcon.Size = new System.Drawing.Size(332, 57);
            this.m_optionalDefaultIcon.TabIndex = 14;
            this.m_optionalDefaultIcon.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // m_optionalPSROMPath
            // 
            this.m_optionalPSROMPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_optionalPSROMPath.Hint = "PSVita ROMs path";
            this.m_optionalPSROMPath.Location = new System.Drawing.Point(0, 96);
            this.m_optionalPSROMPath.MinimumSize = new System.Drawing.Size(0, 57);
            this.m_optionalPSROMPath.Name = "m_optionalPSROMPath";
            this.m_optionalPSROMPath.Size = new System.Drawing.Size(332, 57);
            this.m_optionalPSROMPath.TabIndex = 13;
            this.m_optionalPSROMPath.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // m_extensions
            // 
            this.m_extensions.AnimateReadOnly = false;
            this.m_extensions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_extensions.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_extensions.Depth = 0;
            this.m_extensions.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_extensions.ErrorMessage = "Required";
            this.m_extensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_extensions.HelperText = "Comma separated list of ROM file extensions (.gba, .gb)";
            this.m_extensions.HideSelection = true;
            this.m_extensions.Hint = "Extensions";
            this.m_extensions.LeadingIcon = null;
            this.m_extensions.Location = new System.Drawing.Point(0, 48);
            this.m_extensions.MaxLength = 32767;
            this.m_extensions.MouseState = MaterialSkin.MouseState.OUT;
            this.m_extensions.Name = "m_extensions";
            this.m_extensions.PasswordChar = '\0';
            this.m_extensions.PrefixSuffixText = null;
            this.m_extensions.ReadOnly = false;
            this.m_extensions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_extensions.SelectedText = "";
            this.m_extensions.SelectionLength = 0;
            this.m_extensions.SelectionStart = 0;
            this.m_extensions.ShortcutsEnabled = true;
            this.m_extensions.Size = new System.Drawing.Size(332, 48);
            this.m_extensions.TabIndex = 12;
            this.m_extensions.TabStop = false;
            this.m_extensions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_extensions.TrailingIcon = null;
            this.m_extensions.UseSystemPasswordChar = false;
            this.m_extensions.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // m_platformName
            // 
            this.m_platformName.AnimateReadOnly = false;
            this.m_platformName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_platformName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_platformName.Depth = 0;
            this.m_platformName.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_platformName.ErrorMessage = "Required";
            this.m_platformName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_platformName.HelperText = "Name as listed on http://thumbnails.libretro.com/";
            this.m_platformName.HideSelection = true;
            this.m_platformName.Hint = "Platform name";
            this.m_platformName.LeadingIcon = null;
            this.m_platformName.Location = new System.Drawing.Point(0, 0);
            this.m_platformName.MaxLength = 32767;
            this.m_platformName.MouseState = MaterialSkin.MouseState.OUT;
            this.m_platformName.Name = "m_platformName";
            this.m_platformName.PasswordChar = '\0';
            this.m_platformName.PrefixSuffixText = null;
            this.m_platformName.ReadOnly = false;
            this.m_platformName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_platformName.SelectedText = "";
            this.m_platformName.SelectionLength = 0;
            this.m_platformName.SelectionStart = 0;
            this.m_platformName.ShortcutsEnabled = true;
            this.m_platformName.Size = new System.Drawing.Size(332, 48);
            this.m_platformName.TabIndex = 11;
            this.m_platformName.TabStop = false;
            this.m_platformName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_platformName.TrailingIcon = null;
            this.m_platformName.UseSystemPasswordChar = false;
            this.m_platformName.TextChanged += new System.EventHandler(this.OnAnyTextChanged);
            // 
            // ExtraSettingsElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.baseExpansionPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(0, 56);
            this.Name = "ExtraSettingsElement";
            this.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Size = new System.Drawing.Size(678, 644);
            this.baseExpansionPanel.ResumeLayout(false);
            this.baseExpansionPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialExpansionPanel baseExpansionPanel;
        private Panel panel1;
        private NullableTextField m_optionalStartupHTMLID;
        private NullableTextField m_optionalBGHTMLID;
        private NullableTextField m_optionalIconHTMLID;
        private NullableTextField m_optionalDefaultStartup;
        private NullableTextField m_optionalDefaultBG;
        private NullableTextField m_optionalDefaultIcon;
        private NullableTextField m_optionalPSROMPath;
        private MaterialSkin.Controls.MaterialTextBox2 m_extensions;
        private MaterialSkin.Controls.MaterialTextBox2 m_platformName;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialSwitch m_cleanVisualGameName;
        private MaterialSkin.Controls.MaterialSwitch m_alwaysDefaultStartup;
        private MaterialSkin.Controls.MaterialSwitch m_alwaysDefaultIcon;
        private MaterialSkin.Controls.MaterialSwitch m_alwaysDefaultBackground;
        private Panel panel3;
    }
}
