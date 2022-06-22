namespace BubbleBlower.View
{
    partial class NullableSwitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NullableSwitch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_clearButton = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.m_switch = new MaterialSkin.Controls.MaterialSwitch();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_clearButton);
            this.panel1.Controls.Add(this.m_switch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 2, 40, 2);
            this.panel1.Size = new System.Drawing.Size(244, 51);
            this.panel1.TabIndex = 5;
            // 
            // m_clearButton
            // 
            this.m_clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_clearButton.Depth = 0;
            this.m_clearButton.Icon = ((System.Drawing.Image)(resources.GetObject("m_clearButton.Icon")));
            this.m_clearButton.Location = new System.Drawing.Point(192, 5);
            this.m_clearButton.Mini = true;
            this.m_clearButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_clearButton.Name = "m_clearButton";
            this.m_clearButton.Size = new System.Drawing.Size(40, 47);
            this.m_clearButton.TabIndex = 3;
            this.m_clearButton.Text = "materialFloatingActionButton1";
            this.m_clearButton.UseVisualStyleBackColor = true;
            // 
            // m_switch
            // 
            this.m_switch.AutoSize = true;
            this.m_switch.Depth = 0;
            this.m_switch.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_switch.Location = new System.Drawing.Point(0, 2);
            this.m_switch.Margin = new System.Windows.Forms.Padding(0);
            this.m_switch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.m_switch.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_switch.Name = "m_switch";
            this.m_switch.Ripple = true;
            this.m_switch.Size = new System.Drawing.Size(89, 47);
            this.m_switch.TabIndex = 4;
            this.m_switch.Text = "Test";
            this.m_switch.UseVisualStyleBackColor = true;
            // 
            // NullableSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Name = "NullableSwitch";
            this.Size = new System.Drawing.Size(244, 51);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialFloatingActionButton m_clearButton;
        private MaterialSkin.Controls.MaterialSwitch m_switch;
    }
}
