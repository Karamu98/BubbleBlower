using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleBlower.View
{
    public partial class NullableTextField : UserControl
    {
        [Browsable(true)]
        [Category("Property Changed")]
        [Description("Invoked when user changes text")]
        public event EventHandler? TextChanged;

        public string Hint
        {
            get => m_textBox.Hint;
            set => m_textBox.Hint = value;
        }

        public string Text
        {
            get => m_textBox.Text;
            set => m_textBox.Text = value;
        }

        public bool HasChanged
        {
            get
            {
                if (!m_hasBeenSet)
                {
                    return false;
                }
                if (m_startData == null)
                {
                    return GetData() != null;
                }

                return m_textBox.Text != m_startData;
            }
        }
        private string? m_startData = null;
        private bool m_hasBeenSet = false;

        public NullableTextField()
        {
            InitializeComponent();
        }

        public string? GetData()
        {
            if (m_clearButton.Visible)
            {
                return m_textBox.Text;
            }
            return null;
        }

        public void SetData(string? data)
        {
            m_startData = data;
            m_hasBeenSet = true;
            if (data == null)
            {
                ClearField();
            }
            else
            {
                m_textBox.Text = data;
                if (!m_clearButton.Visible)
                {
                    m_clearButton.Visible = true;
                }
            }
        }

        private void ClearField()
        {
            m_textBox.Text = "";
            m_clearButton.Visible = false;
        }

        private void m_clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void m_textBox_TextChanged(object sender, EventArgs e)
        {
            if (!m_clearButton.Visible)
            {
                m_clearButton.Visible = true;
            }

            if(m_textBox.Text == "" && m_startData == null)
            {
                m_clearButton.Visible = false;
            }

            TextChanged?.Invoke(this, e);
        }
    }
}
