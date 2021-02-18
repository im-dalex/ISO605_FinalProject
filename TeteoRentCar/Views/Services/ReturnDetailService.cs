using BRC.Bussiness.Entities;
using BRC.Bussiness.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeteoRentCar.Utilities;
using TRC.Bussiness.Repository;

namespace TeteoRentCar.Views.Services
{
    public partial class ReturnDetailService : Form
    {
        private GenericRepository<ReturnDetail> _returnDetail;
        private GenericRepository<RentDetail> _rentDetail;
        private GenericRepository<Customer> _customer;
        private GenericRepository<Vehicle> _vehicle;
        private bool _editionMode;
        private ReturnDetail _entityToEdit;
        private int _gridViewLastSelectedRowIndex = 0;
        private int _rentDataGridLastSelectedRowIndex = 0;

        public ReturnDetailService()
        {
            InitializeComponent();
            _rentDetail = new GenericRepository<RentDetail>();
            _returnDetail = new GenericRepository<ReturnDetail>();
        }

        private async Task RefreshGridView()
        {
            var data = await _returnDetail.GetAll(nameof(RentDetail));

            returnDataGrid.DataSource = data.Select(d => new {
                d.Id,
                RentComment = d.RentDetail.Comment,
                d.Date,
                d.Comment,
                d.Status
            }).ToList();

            var rentData = await _rentDetail.GetAll(nameof(Vehicle), nameof(Customer), nameof(Employee));

            rentDataGrid.DataSource = rentData.Select(d => new {
                d.Id,
                Vehicle = d.Vehicle.Description,
                Customer = d.Customer.Name,
                d.RentDate,
                d.PriceByDay,
                d.Comment,
                d.Status
            }).Where(r => r.Status == "A").ToList();
        }

        private void CleanForm()
        {
            ActionControl.ClearTextBoxes(commentTxt);
            cbStatus.SelectedIndex = 0;
            dpDate.Value = DateTime.Today;
        }

        private int GetIdCurrentRow()
        {
            return int.TryParse(returnDataGrid.CurrentRow.Cells[nameof(ReturnDetail.Id)].Value.ToString(), out int id) ? id : 0;
        }

        private async Task DeleteEntity(int Id)
        {
            await _returnDetail.Delete(Id);
            await _returnDetail.SaveAsync();
        }

        private async Task EditionModeToggle()
        {
            if (_editionMode)
            {
                EditBtn.Text = "Editar";
                CleanForm();
            }
            else
            {
                _entityToEdit = await _returnDetail.Get(GetIdCurrentRow());
                EditBtn.Text = "Cancelar";

                commentTxt.Text = _entityToEdit.Comment;
                dpDate.Value = _entityToEdit.Date;
                cbStatus.SelectedItem = _entityToEdit.Status;

            }

            DeleteBtn.Enabled = !DeleteBtn.Enabled;
            rentDataGrid.Enabled = !rentDataGrid.Enabled;
            returnDataGrid.Enabled = !returnDataGrid.Enabled;

            _editionMode = !_editionMode;
        }

        private async Task SaveEntity(bool exists)
        {
            if (!exists)
            {
                var returnDetail = new ReturnDetail()
                {
                    Date = dpDate.Value,
                    Status = cbStatus.Text.Trim(),
                    Comment = commentTxt.Text.Trim(),
                    RentDetailId = int.TryParse(rentDataGrid.CurrentRow.Cells[nameof(RentDetail.Id)].Value.ToString(), out int rentDetailId) ? rentDetailId : 0
                };
                await _returnDetail.Add(returnDetail);
                if (returnDetail.Status == "A")
                {
                    var rent = await _rentDetail.Get(returnDetail.RentDetailId);
                    rent.Status = "D";
                    _rentDetail.Update(rent);
                    await _rentDetail.SaveAsync();
                }
            }
            else
            {
                _entityToEdit.Date = dpDate.Value;
                _entityToEdit.Status = cbStatus.Text;
                _entityToEdit.Comment = commentTxt.Text;
                _returnDetail.Update(_entityToEdit);

                if (_entityToEdit.Status == "I")
                {
                    var rent = await _rentDetail.Get(_entityToEdit.RentDetailId);
                    rent.Status = "A";
                    _rentDetail.Update(rent);
                    await _rentDetail.SaveAsync();
                }
            }
            await _returnDetail.SaveAsync();
        }

        private async void ReturnDetailService_Load(object sender, EventArgs e)
        {
            await RefreshGridView();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (returnDataGrid.CurrentRow == null) return;

            var id = GetIdCurrentRow();

            DialogResult dialogResult = MessageBox.Show($"Esta seguro que quiere eliminar el registro #{id}?", "Eliminar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                await DeleteEntity(id);
                await RefreshGridView();
            }

            returnDataGrid.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (returnDataGrid == null) return;

            await EditionModeToggle();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (rentDataGrid == null) return;

            if (_editionMode)
            {
                string msj = $"Esta seguro que quiere editar el registro #{_entityToEdit.Id}? Esta acción no se podra deshacer.";
                DialogResult dialogResult = MessageBox.Show(msj, "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult != DialogResult.Yes)
                    return;

                await SaveEntity(true);
                await EditionModeToggle();
            }
            else
            {
                await SaveEntity(false);
                _gridViewLastSelectedRowIndex = rentDataGrid.Rows.Count - 1;
            }

            rentDataGrid.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;

            await RefreshGridView();
            CleanForm();
        }

        private void returnDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            _gridViewLastSelectedRowIndex = returnDataGrid.CurrentRow.Index;
        }

        private void rentDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            _rentDataGridLastSelectedRowIndex = rentDataGrid.CurrentRow.Index;
        }
    }
}
