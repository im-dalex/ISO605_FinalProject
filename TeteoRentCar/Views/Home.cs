﻿using System;
using System.Windows.Forms;
using TeteoRentCar.Utilities;
using TeteoRentCar.Views.Maintenance;
using TeteoRentCar.Views.Services;

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
            ActionControl.OpenChildForm(new VehicleBrandCRUD(), containerPanel);
        }

        private void modelBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new VehicleModelCRUD(), containerPanel);
        }

        private void fuelBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new FuelTypeCRUD(), containerPanel);
        }

        private void vehicleBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new VehicleCRUD(), containerPanel);
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new CustomerCRUD(), containerPanel);
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new EmployeeCRUD(), containerPanel);
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new RentDetail(), containerPanel);
        }

        private void inspectionBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new Inspection(), containerPanel);
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ActionControl.OpenChildForm(new ReturnDetail(), containerPanel);
        }
    }
}
