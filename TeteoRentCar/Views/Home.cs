using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TeteoRentCar.Views
{
    public partial class Home : Form
    {
        private Button _activeBtn;
        public Home()
        {
            InitializeComponent();
            HideSubModulePanel();
        }

        private void HideSubModulePanel()
        {
            maintenanceSubModulePanel.Visible = false;
            processSubModulePanel.Visible = false;
        }

        private void ManageSubModulePanel(object btn, Panel panel = null)
        {
            HighLigthBtn(btn);
            HideSubModulePanel();
            if (panel != null) 
                panel.Visible = !panel.Visible; 
        }

        private void HighLigthBtn(object btn)
        {
            if (btn != null && _activeBtn != (Button)btn)
            {
                DisableHighLigth();
                _activeBtn = (Button)btn;
                _activeBtn.BackColor = Color.DeepSkyBlue;
            }
        }

        private void DisableHighLigth()
        {
            foreach (Control control in sideBar.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.FromArgb(41, 39, 40);
                }
            }
        }

        private void maintenanceBtn_Click(object sender, EventArgs e)
        {
            ManageSubModulePanel(sender, maintenanceSubModulePanel);
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            ManageSubModulePanel(sender, processSubModulePanel);
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ManageSubModulePanel(sender);
        }
    }
}
