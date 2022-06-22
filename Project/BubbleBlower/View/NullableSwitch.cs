using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// This could probably be templated since lots of duplicated code with NullableTextField
/// </summary>
namespace BubbleBlower.View
{
    public partial class NullableSwitch : UserControl
    {
        [Browsable(true)]
        [Category("Property Changed")]
        [Description("Invoked when user changes switch")]
        public event EventHandler? SwitchChanged;

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

                return m_switch.Checked != m_startData;
            }
        }
        private bool? m_startData = null;
        private bool m_hasBeenSet = false;

        public NullableSwitch()
        {
            InitializeComponent();
        }

        public bool? GetData()
        {
            if (m_clearButton.Visible)
            {
                return m_switch.Checked;
            }
            return null;
        }

        public void SetData(bool? data)
        {
            m_startData = data;
            m_hasBeenSet = true;
            if (data == null)
            {
                ClearField();
            }
            else
            {
                m_switch.Checked = data.Value;
                if (!m_clearButton.Visible)
                {
                    m_clearButton.Visible = true;
                }
            }
        }

        private void ClearField()
        {
            m_switch.CheckState = CheckState.Indeterminate;
            m_clearButton.Visible = false;
        }

        private void m_clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }
    }
}
