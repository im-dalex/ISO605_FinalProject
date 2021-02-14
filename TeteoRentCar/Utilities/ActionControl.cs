using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeteoRentCar.Utilities
{
    public class ActionControl
    {
        private static Form _activeForm;
        private static Button _activeBtn;

        public static void HighLigthBtn(object btn, Panel panel)
        {
            if (btn != null && _activeBtn != (Button)btn)
            {
                DisableHighLigth(panel);
                _activeBtn = (Button)btn;
                _activeBtn.BackColor = Color.DeepSkyBlue;
            }
        }

        private static void DisableHighLigth(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.FromArgb(41, 39, 40);
                }
            }
        }

        public static void OpenChildForm(Form childForm, Panel containerPanel)
        {
            if (_activeForm != null) _activeForm.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(childForm);
            containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        public static void ClearTextBoxes(TextBox[] controls)
        {
            foreach (var control in controls)
            {
                control.Clear();
            }
        }
    }
}
