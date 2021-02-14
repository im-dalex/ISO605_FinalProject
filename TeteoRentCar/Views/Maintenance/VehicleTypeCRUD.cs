using BRC.Bussiness.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TRC.Bussiness.Context;
using TRC.Bussiness.Repository;

namespace TeteoRentCar.Views.Maintenance
{
    public partial class VehicleTypeCRUD : Form
    {
        private GenericRepository<VehicleType> _vehicleType;
        public VehicleTypeCRUD()
        {
            _vehicleType = new GenericRepository<VehicleType>();
            InitializeComponent();
        }

        private void VehicleTypeCRUD_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        private async void RefreshGridView()
        {
            var data = await _vehicleType.GetAll();
            dataGridView1.DataSource = data;
        }

        private async void SaveEntity()
        {
            //cbStatus.SelectedItem;
            var vehicleType = new VehicleType()
            {
                Description = txtDescription.Text.Trim(),
                Status = "A"
            };
            await _vehicleType.Add(vehicleType);
            await _vehicleType.SaveAsync();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEntity();
        }
    }
}
