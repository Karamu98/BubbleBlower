namespace BubbleBlower
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Builder = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_saveChangesButton = new MaterialSkin.Controls.MaterialButton();
            this.ExtraSettingsScroll = new System.Windows.Forms.Panel();
            this.m_startupHTMLID = new MaterialSkin.Controls.MaterialTextBox2();
            this.m_bgHTMLID = new MaterialSkin.Controls.MaterialTextBox2();
            this.m_iconHTMLID = new MaterialSkin.Controls.MaterialTextBox2();
            this.m_defaultStartupPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.m_defaultBackgroundPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.m_defaultIconPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.m_psVitaROMPath = new MaterialSkin.Controls.MaterialTextBox2();
            this.m_alwaysDefaultStartup = new MaterialSkin.Controls.MaterialSwitch();
            this.m_alwaysDefaultBackground = new MaterialSkin.Controls.MaterialSwitch();
            this.m_alwaysDefaultIcon = new MaterialSkin.Controls.MaterialSwitch();
            this.m_cleanVisualGameName = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabsImageList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.Settings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Builder);
            this.materialTabControl1.Controls.Add(this.Settings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.tabsImageList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1489, 687);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Builder
            // 
            this.Builder.ImageKey = "download_FILL0_wght400_GRAD0_opsz48.png";
            this.Builder.Location = new System.Drawing.Point(4, 31);
            this.Builder.Name = "Builder";
            this.Builder.Padding = new System.Windows.Forms.Padding(3);
            this.Builder.Size = new System.Drawing.Size(1481, 652);
            this.Builder.TabIndex = 0;
            this.Builder.Text = "Builder";
            this.Builder.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.panel1);
            this.Settings.ImageKey = "settings_FILL0_wght400_GRAD0_opsz48.png";
            this.Settings.Location = new System.Drawing.Point(4, 31);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1481, 652);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_saveChangesButton);
            this.panel1.Controls.Add(this.ExtraSettingsScroll);
            this.panel1.Controls.Add(this.m_startupHTMLID);
            this.panel1.Controls.Add(this.m_bgHTMLID);
            this.panel1.Controls.Add(this.m_iconHTMLID);
            this.panel1.Controls.Add(this.m_defaultStartupPath);
            this.panel1.Controls.Add(this.m_defaultBackgroundPath);
            this.panel1.Controls.Add(this.m_defaultIconPath);
            this.panel1.Controls.Add(this.m_psVitaROMPath);
            this.panel1.Controls.Add(this.m_alwaysDefaultStartup);
            this.panel1.Controls.Add(this.m_alwaysDefaultBackground);
            this.panel1.Controls.Add(this.m_alwaysDefaultIcon);
            this.panel1.Controls.Add(this.m_cleanVisualGameName);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(16);
            this.panel1.Size = new System.Drawing.Size(1475, 646);
            this.panel1.TabIndex = 5;
            // 
            // m_saveChangesButton
            // 
            this.m_saveChangesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_saveChangesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.m_saveChangesButton.Depth = 0;
            this.m_saveChangesButton.Enabled = false;
            this.m_saveChangesButton.HighEmphasis = true;
            this.m_saveChangesButton.Icon = null;
            this.m_saveChangesButton.Location = new System.Drawing.Point(19, 594);
            this.m_saveChangesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.m_saveChangesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_saveChangesButton.Name = "m_saveChangesButton";
            this.m_saveChangesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.m_saveChangesButton.Size = new System.Drawing.Size(64, 36);
            this.m_saveChangesButton.TabIndex = 19;
            this.m_saveChangesButton.Text = "Save";
            this.m_saveChangesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.m_saveChangesButton.UseAccentColor = false;
            this.m_saveChangesButton.UseVisualStyleBackColor = true;
            this.m_saveChangesButton.Click += new System.EventHandler(this.m_saveChangesButton_Click);
            // 
            // ExtraSettingsScroll
            // 
            this.ExtraSettingsScroll.AutoScroll = true;
            this.ExtraSettingsScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExtraSettingsScroll.Location = new System.Drawing.Point(909, 16);
            this.ExtraSettingsScroll.Name = "ExtraSettingsScroll";
            this.ExtraSettingsScroll.Size = new System.Drawing.Size(550, 614);
            this.ExtraSettingsScroll.TabIndex = 18;
            // 
            // m_startupHTMLID
            // 
            this.m_startupHTMLID.AnimateReadOnly = false;
            this.m_startupHTMLID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_startupHTMLID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_startupHTMLID.Depth = 0;
            this.m_startupHTMLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_startupHTMLID.HideSelection = true;
            this.m_startupHTMLID.Hint = "Startup identifier";
            this.m_startupHTMLID.LeadingIcon = null;
            this.m_startupHTMLID.Location = new System.Drawing.Point(19, 380);
            this.m_startupHTMLID.MaxLength = 32767;
            this.m_startupHTMLID.MouseState = MaterialSkin.MouseState.OUT;
            this.m_startupHTMLID.Name = "m_startupHTMLID";
            this.m_startupHTMLID.PasswordChar = '\0';
            this.m_startupHTMLID.PrefixSuffixText = null;
            this.m_startupHTMLID.ReadOnly = false;
            this.m_startupHTMLID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_startupHTMLID.SelectedText = "";
            this.m_startupHTMLID.SelectionLength = 0;
            this.m_startupHTMLID.SelectionStart = 0;
            this.m_startupHTMLID.ShortcutsEnabled = true;
            this.m_startupHTMLID.Size = new System.Drawing.Size(314, 48);
            this.m_startupHTMLID.TabIndex = 17;
            this.m_startupHTMLID.TabStop = false;
            this.m_startupHTMLID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_startupHTMLID.TrailingIcon = null;
            this.m_startupHTMLID.UseSystemPasswordChar = false;
            // 
            // m_bgHTMLID
            // 
            this.m_bgHTMLID.AnimateReadOnly = false;
            this.m_bgHTMLID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_bgHTMLID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_bgHTMLID.Depth = 0;
            this.m_bgHTMLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_bgHTMLID.HideSelection = true;
            this.m_bgHTMLID.Hint = "Background identifier";
            this.m_bgHTMLID.LeadingIcon = null;
            this.m_bgHTMLID.Location = new System.Drawing.Point(19, 326);
            this.m_bgHTMLID.MaxLength = 32767;
            this.m_bgHTMLID.MouseState = MaterialSkin.MouseState.OUT;
            this.m_bgHTMLID.Name = "m_bgHTMLID";
            this.m_bgHTMLID.PasswordChar = '\0';
            this.m_bgHTMLID.PrefixSuffixText = null;
            this.m_bgHTMLID.ReadOnly = false;
            this.m_bgHTMLID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_bgHTMLID.SelectedText = "";
            this.m_bgHTMLID.SelectionLength = 0;
            this.m_bgHTMLID.SelectionStart = 0;
            this.m_bgHTMLID.ShortcutsEnabled = true;
            this.m_bgHTMLID.Size = new System.Drawing.Size(314, 48);
            this.m_bgHTMLID.TabIndex = 16;
            this.m_bgHTMLID.TabStop = false;
            this.m_bgHTMLID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_bgHTMLID.TrailingIcon = null;
            this.m_bgHTMLID.UseSystemPasswordChar = false;
            // 
            // m_iconHTMLID
            // 
            this.m_iconHTMLID.AnimateReadOnly = false;
            this.m_iconHTMLID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_iconHTMLID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_iconHTMLID.Depth = 0;
            this.m_iconHTMLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_iconHTMLID.HideSelection = true;
            this.m_iconHTMLID.Hint = "Icon identifier";
            this.m_iconHTMLID.LeadingIcon = null;
            this.m_iconHTMLID.Location = new System.Drawing.Point(19, 272);
            this.m_iconHTMLID.MaxLength = 32767;
            this.m_iconHTMLID.MouseState = MaterialSkin.MouseState.OUT;
            this.m_iconHTMLID.Name = "m_iconHTMLID";
            this.m_iconHTMLID.PasswordChar = '\0';
            this.m_iconHTMLID.PrefixSuffixText = null;
            this.m_iconHTMLID.ReadOnly = false;
            this.m_iconHTMLID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_iconHTMLID.SelectedText = "";
            this.m_iconHTMLID.SelectionLength = 0;
            this.m_iconHTMLID.SelectionStart = 0;
            this.m_iconHTMLID.ShortcutsEnabled = true;
            this.m_iconHTMLID.Size = new System.Drawing.Size(314, 48);
            this.m_iconHTMLID.TabIndex = 15;
            this.m_iconHTMLID.TabStop = false;
            this.m_iconHTMLID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_iconHTMLID.TrailingIcon = null;
            this.m_iconHTMLID.UseSystemPasswordChar = false;
            // 
            // m_defaultStartupPath
            // 
            this.m_defaultStartupPath.AnimateReadOnly = false;
            this.m_defaultStartupPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_defaultStartupPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_defaultStartupPath.Depth = 0;
            this.m_defaultStartupPath.ErrorMessage = "Required";
            this.m_defaultStartupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_defaultStartupPath.HideSelection = true;
            this.m_defaultStartupPath.Hint = "Default startup";
            this.m_defaultStartupPath.LeadingIcon = null;
            this.m_defaultStartupPath.Location = new System.Drawing.Point(19, 218);
            this.m_defaultStartupPath.MaxLength = 32767;
            this.m_defaultStartupPath.MouseState = MaterialSkin.MouseState.OUT;
            this.m_defaultStartupPath.Name = "m_defaultStartupPath";
            this.m_defaultStartupPath.PasswordChar = '\0';
            this.m_defaultStartupPath.PrefixSuffixText = null;
            this.m_defaultStartupPath.ReadOnly = false;
            this.m_defaultStartupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_defaultStartupPath.SelectedText = "";
            this.m_defaultStartupPath.SelectionLength = 0;
            this.m_defaultStartupPath.SelectionStart = 0;
            this.m_defaultStartupPath.ShortcutsEnabled = true;
            this.m_defaultStartupPath.Size = new System.Drawing.Size(314, 48);
            this.m_defaultStartupPath.TabIndex = 14;
            this.m_defaultStartupPath.TabStop = false;
            this.m_defaultStartupPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_defaultStartupPath.TrailingIcon = null;
            this.m_defaultStartupPath.UseSystemPasswordChar = false;
            // 
            // m_defaultBackgroundPath
            // 
            this.m_defaultBackgroundPath.AnimateReadOnly = false;
            this.m_defaultBackgroundPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_defaultBackgroundPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_defaultBackgroundPath.Depth = 0;
            this.m_defaultBackgroundPath.ErrorMessage = "Required";
            this.m_defaultBackgroundPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_defaultBackgroundPath.HideSelection = true;
            this.m_defaultBackgroundPath.Hint = "Default background";
            this.m_defaultBackgroundPath.LeadingIcon = null;
            this.m_defaultBackgroundPath.Location = new System.Drawing.Point(19, 164);
            this.m_defaultBackgroundPath.MaxLength = 32767;
            this.m_defaultBackgroundPath.MouseState = MaterialSkin.MouseState.OUT;
            this.m_defaultBackgroundPath.Name = "m_defaultBackgroundPath";
            this.m_defaultBackgroundPath.PasswordChar = '\0';
            this.m_defaultBackgroundPath.PrefixSuffixText = null;
            this.m_defaultBackgroundPath.ReadOnly = false;
            this.m_defaultBackgroundPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_defaultBackgroundPath.SelectedText = "";
            this.m_defaultBackgroundPath.SelectionLength = 0;
            this.m_defaultBackgroundPath.SelectionStart = 0;
            this.m_defaultBackgroundPath.ShortcutsEnabled = true;
            this.m_defaultBackgroundPath.Size = new System.Drawing.Size(314, 48);
            this.m_defaultBackgroundPath.TabIndex = 13;
            this.m_defaultBackgroundPath.TabStop = false;
            this.m_defaultBackgroundPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_defaultBackgroundPath.TrailingIcon = null;
            this.m_defaultBackgroundPath.UseSystemPasswordChar = false;
            // 
            // m_defaultIconPath
            // 
            this.m_defaultIconPath.AnimateReadOnly = false;
            this.m_defaultIconPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_defaultIconPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_defaultIconPath.Depth = 0;
            this.m_defaultIconPath.ErrorMessage = "Required";
            this.m_defaultIconPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_defaultIconPath.HideSelection = true;
            this.m_defaultIconPath.Hint = "Default icon";
            this.m_defaultIconPath.LeadingIcon = null;
            this.m_defaultIconPath.Location = new System.Drawing.Point(19, 109);
            this.m_defaultIconPath.MaxLength = 32767;
            this.m_defaultIconPath.MouseState = MaterialSkin.MouseState.OUT;
            this.m_defaultIconPath.Name = "m_defaultIconPath";
            this.m_defaultIconPath.PasswordChar = '\0';
            this.m_defaultIconPath.PrefixSuffixText = null;
            this.m_defaultIconPath.ReadOnly = false;
            this.m_defaultIconPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_defaultIconPath.SelectedText = "";
            this.m_defaultIconPath.SelectionLength = 0;
            this.m_defaultIconPath.SelectionStart = 0;
            this.m_defaultIconPath.ShortcutsEnabled = true;
            this.m_defaultIconPath.Size = new System.Drawing.Size(314, 48);
            this.m_defaultIconPath.TabIndex = 12;
            this.m_defaultIconPath.TabStop = false;
            this.m_defaultIconPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_defaultIconPath.TrailingIcon = null;
            this.m_defaultIconPath.UseSystemPasswordChar = false;
            // 
            // m_psVitaROMPath
            // 
            this.m_psVitaROMPath.AnimateReadOnly = false;
            this.m_psVitaROMPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.m_psVitaROMPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.m_psVitaROMPath.Depth = 0;
            this.m_psVitaROMPath.ErrorMessage = "Required";
            this.m_psVitaROMPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_psVitaROMPath.HelperText = "Helper Text";
            this.m_psVitaROMPath.HideSelection = true;
            this.m_psVitaROMPath.Hint = "PSVita ROMs path";
            this.m_psVitaROMPath.LeadingIcon = null;
            this.m_psVitaROMPath.Location = new System.Drawing.Point(19, 55);
            this.m_psVitaROMPath.MaxLength = 32767;
            this.m_psVitaROMPath.MouseState = MaterialSkin.MouseState.OUT;
            this.m_psVitaROMPath.Name = "m_psVitaROMPath";
            this.m_psVitaROMPath.PasswordChar = '\0';
            this.m_psVitaROMPath.PrefixSuffixText = null;
            this.m_psVitaROMPath.ReadOnly = false;
            this.m_psVitaROMPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_psVitaROMPath.SelectedText = "";
            this.m_psVitaROMPath.SelectionLength = 0;
            this.m_psVitaROMPath.SelectionStart = 0;
            this.m_psVitaROMPath.ShortcutsEnabled = true;
            this.m_psVitaROMPath.Size = new System.Drawing.Size(314, 48);
            this.m_psVitaROMPath.TabIndex = 11;
            this.m_psVitaROMPath.TabStop = false;
            this.m_psVitaROMPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.m_psVitaROMPath.TrailingIcon = null;
            this.m_psVitaROMPath.UseSystemPasswordChar = false;
            // 
            // m_alwaysDefaultStartup
            // 
            this.m_alwaysDefaultStartup.AutoSize = true;
            this.m_alwaysDefaultStartup.Depth = 0;
            this.m_alwaysDefaultStartup.Location = new System.Drawing.Point(353, 217);
            this.m_alwaysDefaultStartup.Margin = new System.Windows.Forms.Padding(0);
            this.m_alwaysDefaultStartup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_alwaysDefaultStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_alwaysDefaultStartup.Name = "m_alwaysDefaultStartup";
            this.m_alwaysDefaultStartup.Ripple = true;
            this.m_alwaysDefaultStartup.Size = new System.Drawing.Size(221, 37);
            this.m_alwaysDefaultStartup.TabIndex = 10;
            this.m_alwaysDefaultStartup.Text = "Always Default Startup";
            this.m_alwaysDefaultStartup.UseVisualStyleBackColor = true;
            // 
            // m_alwaysDefaultBackground
            // 
            this.m_alwaysDefaultBackground.AutoSize = true;
            this.m_alwaysDefaultBackground.Depth = 0;
            this.m_alwaysDefaultBackground.Location = new System.Drawing.Point(353, 161);
            this.m_alwaysDefaultBackground.Margin = new System.Windows.Forms.Padding(0);
            this.m_alwaysDefaultBackground.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_alwaysDefaultBackground.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_alwaysDefaultBackground.Name = "m_alwaysDefaultBackground";
            this.m_alwaysDefaultBackground.Ripple = true;
            this.m_alwaysDefaultBackground.Size = new System.Drawing.Size(254, 37);
            this.m_alwaysDefaultBackground.TabIndex = 9;
            this.m_alwaysDefaultBackground.Text = "Always Default Background";
            this.m_alwaysDefaultBackground.UseVisualStyleBackColor = true;
            // 
            // m_alwaysDefaultIcon
            // 
            this.m_alwaysDefaultIcon.AutoSize = true;
            this.m_alwaysDefaultIcon.Depth = 0;
            this.m_alwaysDefaultIcon.Location = new System.Drawing.Point(353, 105);
            this.m_alwaysDefaultIcon.Margin = new System.Windows.Forms.Padding(0);
            this.m_alwaysDefaultIcon.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_alwaysDefaultIcon.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_alwaysDefaultIcon.Name = "m_alwaysDefaultIcon";
            this.m_alwaysDefaultIcon.Ripple = true;
            this.m_alwaysDefaultIcon.Size = new System.Drawing.Size(199, 37);
            this.m_alwaysDefaultIcon.TabIndex = 8;
            this.m_alwaysDefaultIcon.Text = "Always Default Icon";
            this.m_alwaysDefaultIcon.UseVisualStyleBackColor = true;
            // 
            // m_cleanVisualGameName
            // 
            this.m_cleanVisualGameName.AutoSize = true;
            this.m_cleanVisualGameName.Depth = 0;
            this.m_cleanVisualGameName.Location = new System.Drawing.Point(353, 55);
            this.m_cleanVisualGameName.Margin = new System.Windows.Forms.Padding(0);
            this.m_cleanVisualGameName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_cleanVisualGameName.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_cleanVisualGameName.Name = "m_cleanVisualGameName";
            this.m_cleanVisualGameName.Ripple = true;
            this.m_cleanVisualGameName.Size = new System.Drawing.Size(217, 37);
            this.m_cleanVisualGameName.TabIndex = 7;
            this.m_cleanVisualGameName.Text = "Sanitise Visual Names";
            this.m_cleanVisualGameName.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(19, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Base Settings";
            // 
            // tabsImageList
            // 
            this.tabsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.tabsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabsImageList.ImageStream")));
            this.tabsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabsImageList.Images.SetKeyName(0, "download_FILL0_wght400_GRAD0_opsz48.png");
            this.tabsImageList.Images.SetKeyName(1, "settings_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 754);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "Bubble Blower";
            this.materialTabControl1.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Builder;
        private TabPage Settings;
        private ImageList tabsImageList;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSwitch m_alwaysDefaultStartup;
        private MaterialSkin.Controls.MaterialSwitch m_alwaysDefaultBackground;
        private MaterialSkin.Controls.MaterialSwitch m_alwaysDefaultIcon;
        private MaterialSkin.Controls.MaterialSwitch m_cleanVisualGameName;
        private MaterialSkin.Controls.MaterialTextBox2 m_bgHTMLID;
        private MaterialSkin.Controls.MaterialTextBox2 m_iconHTMLID;
        private MaterialSkin.Controls.MaterialTextBox2 m_defaultStartupPath;
        private MaterialSkin.Controls.MaterialTextBox2 m_defaultBackgroundPath;
        private MaterialSkin.Controls.MaterialTextBox2 m_defaultIconPath;
        private MaterialSkin.Controls.MaterialTextBox2 m_psVitaROMPath;
        private MaterialSkin.Controls.MaterialTextBox2 m_startupHTMLID;
        private Panel ExtraSettingsScroll;
        private MaterialSkin.Controls.MaterialButton m_saveChangesButton;
    }
}