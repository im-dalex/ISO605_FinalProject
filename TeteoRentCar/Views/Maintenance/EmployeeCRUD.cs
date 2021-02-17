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
using TeteoRentCar.Utilities;
using TRC.Bussiness.Context;
using TRC.Bussiness.Repository;

namespace TeteoRentCar.Views.Maintenance
{
    public partial class EmployeeCRUD : Form
    {
        private GenericRepository<Employee> _Employee;
        private Employee _entityToEdit;
        private bool _editionMode;
        private int _gridViewLastSelectedRowIndex = 0;

        public EmployeeCRUD()
        {
            _Employee = new GenericRepository<Employee>();
            InitializeComponent();
        }

        private async void EmployeeCRUD_Load(object sender, EventArgs e)
        {
           await RefreshGridView();
           CleanForm();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            _gridViewLastSelectedRowIndex = dataGridView1.CurrentRow.Index;
        }

        private async Task RefreshGridView()
        {
            var data = await _Employee.GetAll();

            dataGridView1.DataSource = data.Select( d => new {
                d.Id,
                d.Name,
                d.Identification,
                d.Schedule,
                d.Commission,
                d.EntryDate,
                d.Status
            }).ToList();
        }

        private void CleanForm()
        {
            ActionControl.ClearTextBoxes(txtName);
            cbSchedule.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            mTxtIdentification.Text = null;
        }

        private async Task SaveEntity()
        {
            var Employee = new Employee()
            {
                Name = txtName.Text.Trim(),
                Identification = mTxtIdentification.Text.Trim(),
                Schedule = cbSchedule.Text,
                Commission = (int)numericUpDown1.Value,
                Status = cbStatus.Text
            };
            await _Employee.Add(Employee);
            await _Employee.SaveAsync();
        }
        private async Task UpdateEntity()
        {
            _entityToEdit.Name = txtName.Text.Trim();
            _entityToEdit.Identification = mTxtIdentification.Text.Trim();
            _entityToEdit.Schedule = cbSchedule.Text;
            _entityToEdit.Commission = (int)numericUpDown1.Value;
            _entityToEdit.Status = cbStatus.Text;

            _Employee.Update(_entityToEdit);
            await _Employee.SaveAsync();
        }

        private bool IsFormValid()
        {
            return txtName.Text.Trim().Length > 0 && txtName.Text.Trim().Length <= 100
                && Identification.Validate(mTxtIdentification.Text.Trim());
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                string msj = "De lo mio, ten en cuenta que no me puedes de dejar los datos vacios.";
                MessageBox.Show(msj, "Revise los datos!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_editionMode)
            {
                string msj = $"Esta seguro que quiere editar el registro #{_entityToEdit.Id}? Esta acción no se podra deshacer.";
                DialogResult dialogResult = MessageBox.Show(msj, "Modificar",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    await UpdateEntity();
                    await EditionModeToggle();
                    await RefreshGridView();
                }
                else
                    return;
            }
            else
            {
                await SaveEntity();
                await RefreshGridView();
                _gridViewLastSelectedRowIndex = dataGridView1.Rows.Count - 1;
            }

            dataGridView1.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;

            CleanForm();

        }

        private async Task DeleteEntity(int Id)
        {
            await _Employee.Delete(Id);
            await _Employee.SaveAsync();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            var id = GetIdCurrentRow();

            DialogResult dialogResult = MessageBox.Show($"Esta seguro que quiere eliminar el registro #{id}?", "Eliminar",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                await DeleteEntity(id);
                await RefreshGridView();
            }

            dataGridView1.FirstDisplayedScrollingRowIndex = _gridViewLastSelectedRowIndex;

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
                EditBtn.Text = "Cancelar modificacion";

                _entityToEdit = await _Employee.Get(GetIdCurrentRow());
                txtName.Text = _entityToEdit.Name;
                mTxtIdentification.Text = _entityToEdit.Identification;
                cbSchedule.Text = _entityToEdit.Schedule;
                numericUpDown1.Value = _entityToEdit.Commission;
                cbStatus.SelectedItem = _entityToEdit.Status;
                
            }

            DeleteBtn.Enabled = !DeleteBtn.Enabled;
            dataGridView1.Enabled = !dataGridView1.Enabled;
            
            _editionMode = !_editionMode;
        }

        private int GetIdCurrentRow()
        {
            return int.TryParse(dataGridView1.CurrentRow.Cells[nameof(Employee.Id)].Value.ToString(), out int id) ? id : 0;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            await EditionModeToggle();
        }

    }
}
