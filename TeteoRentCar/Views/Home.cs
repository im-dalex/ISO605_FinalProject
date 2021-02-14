using System;
using System.Windows.Forms;
using TeteoRentCar.Utilities;
using TeteoRentCar.Views.Maintenance;

namespace TeteoRentCar.Views
{
    public partial class Home : Form
    {
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
            ActionControl.HighLigthBtn(btn, sideBar);
            HideSubModulePanel();
            if (panel != null) 
                panel.Visible = !panel.Visible; 
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
            ActionControl.OpenChildForm(new Rents(), containerPanel);
            ManageSubModulePanel(sender);
        }

        private void vehicleTypeBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new VehicleTypeCRUD(), containerPanel);
        }

        private void brandBtn_Click(object sender, EventArgs e)
        {
            //ActionControl.OpenChildForm(new Login(), containerPanel);
        }
    }
}
