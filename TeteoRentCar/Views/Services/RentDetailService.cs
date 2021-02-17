using BRC.Bussiness.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRC.Bussiness.Repository;

namespace TeteoRentCar.Views.Services
{
    public partial class RentDetailService : Form
    {
        private GenericRepository<RentDetail> _rentDetail;
        private GenericRepository<Customer> _customer;
        private GenericRepository<Vehicle> _vehicle;
        private GenericRepository<Employee> _employee;

        public RentDetailService()
        {
            InitializeComponent();
            _rentDetail = new GenericRepository<RentDetail>();
            _customer = new GenericRepository<Customer>();
            _vehicle = new GenericRepository<Vehicle>();
            _employee = new GenericRepository<Employee>();
        }

        private async Task RefreshGridView()
        {
            var data = await _rentDetail.GetAll(nameof(Vehicle), nameof(Customer), nameof(Employee));

            rentDataGrid.DataSource = data.Select(d => new {
                d.Id,
                Employee = d.Employee.Name,
                Vehicle = d.Vehicle.Description,
                NoLicensePlate = d.Vehicle.NoLicensePlate,
                Customer = d.Customer.Name,
                d.RentDate,
                d.PriceByDay,
                d.RentDays,
                d.Comment,
                d.Status
            }).ToList();
        }

        private async Task RefreshComboBoxes()
        {
            cbCustomer.DataSource = await _customer.GetAll();
            cbCustomer.ValueMember = nameof(Customer.Id);
            cbCustomer.DisplayMember = nameof(Customer.Name);

            cbVehicle.DataSource = (await _vehicle.GetAll()).Where(v => v.Status != "R").ToList();
            cbVehicle.ValueMember = nameof(Vehicle.Id);
            cbVehicle.DisplayMember = nameof(Vehicle.Description);

            cbEmployee.DataSource = await _employee.GetAll();
            cbEmployee.ValueMember = nameof(Employee.Id);
            cbEmployee.DisplayMember = nameof(Employee.Name);
        }

        private async Task SaveEntity()
        {
            var rentDetail = new RentDetail()
            {
                RentDate = dpRentDate.Value,
                PriceByDay = (double)nPriceByDay.Value,
                RentDays = (int)nRentDays.Value,
                Status = cbStatus.Text,
                Comment = commentTxt.Text,
                EmployeeId = int.TryParse(cbEmployee.SelectedValue.ToString(), out int idEmployee) ? idEmployee : 0,
                VehicleId = int.TryParse(cbVehicle.SelectedValue.ToString(), out int idVehicle) ? idVehicle : 0,
                CustomerId = int.TryParse(cbCustomer.SelectedValue.ToString(), out int idCustomer) ? idCustomer : 0
            };
            await _rentDetail.Add(rentDetail);

            if (rentDetail.Status == "A")
                rentDetail.Vehicle.Status = "R";

            await _rentDetail.SaveAsync();
        }

        private async void RentDetailService_Load(object sender, EventArgs e)
        {
            await RefreshGridView();
            await RefreshComboBoxes(); 
            dpRentDate.MinDate = DateTime.Today;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await SaveEntity();
            await RefreshGridView();
            await RefreshComboBoxes();
        }
    }
}
