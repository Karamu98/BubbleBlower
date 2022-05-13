namespace BubbleBlower.View
{
    partial class NullableTextField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NullableTextField));
            this.m_clearButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_textBox = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_clearButton
            // 
            this.m_clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_clearButton.Depth = 0;
            this.m_clearButton.Icon = ((System.Drawing.Image)(resources.GetObject("m_clearButton.Icon")));
            this.m_clearButton.Location = new System.Drawing.Point(326, 5);
            this.m_clearButton.Mini = true;
            this.m_clearButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_clearButton.Name = "m_clearButton";
            this.m_clearButton.Size = new System.Drawing.Size(40, 40);
            this.m_clearButton.TabIndex = 3;
            this.m_clearButton.Text = "materialFloatingActionButton1";
            this.m_clearButton.UseVisualStyleBackColor = true;
            this.m_clearButton.Click += new System.EventHandler(this.m_clearButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_clearButton);
            this.panel1.Controls.Add(this.m_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 40, 2);
            this.panel1.Size = new System.Drawing.Size(386, 50);
            this.panel1.TabIndex = 4;
            // 
            // m_textBox
            // 
            this.m_textBox.AnimateReadOnly = false;
            this.m_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_textBox.Depth = 0;
            this.m_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_textBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_textBox.Hint = "Hint";
            this.m_textBox.LeadingIcon = null;
            this.m_textBox.Location = new System.Drawing.Point(0, 2);
            this.m_textBox.MaxLength = 50;
            this.m_textBox.MouseState = MaterialSkin.MouseState.OUT;
            this.m_textBox.Multiline = false;
            this.m_textBox.Name = "m_textBox";
            this.m_textBox.Size = new System.Drawing.Size(346, 50);
            this.m_textBox.TabIndex = 0;
            this.m_textBox.Text = "";
            this.m_textBox.TrailingIcon = null;
            this.m_textBox.TextChanged += new System.EventHandler(this.m_textBox_TextChanged);
            // 
            // NullableTextField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(0, 50);
            this.Name = "NullableTextField";
            this.Size = new System.Drawing.Size(386, 50);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialFloatingActionButton m_clearButton;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox m_textBox;
    }
}
