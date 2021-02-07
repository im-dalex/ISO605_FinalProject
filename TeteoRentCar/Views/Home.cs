using System;
using System.Drawing;
using System.Windows.Forms;
using TeteoRentCar.Views.Maintenance;

namespace TeteoRentCar.Views
{
    public partial class Home : Form
    {
        private Button _activeBtn;
        private Form _activeForm;
        public Home()
        {
            InitializeComponent();
            HideSubModulePanel();
        }

        private void OpenChildForm(Form form)
        {
            if (_activeForm != null) _activeForm.Close();

            _activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(form);
            containerPanel.Tag = form;
            form.BringToFront();
            form.Show();
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

        private void vehicleTypeBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new VehicleTypeCRUD());
        }
    }
}
