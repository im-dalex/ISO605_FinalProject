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
    public partial class CustomerCRUD : Form
    {
        private GenericRepository<Customer> _Customer;
        private Customer _entityToEdit;
        private bool _editionMode;
        private int _gridViewLastSelectedRowIndex = 0;

        public CustomerCRUD()
        {
            _Customer = new GenericRepository<Customer>();
            InitializeComponent();
        }

        private async void CustomerCRUD_Load(object sender, EventArgs e)
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
            var data = await _Customer.GetAll();

            dataGridView1.DataSource = data.Select( d => new {
                d.Id,
                d.Name,
                d.Identification,
                d.CreditCard,
                d.CreditLimit,
                d.PersonType,
                d.Status
            }).ToList();
        }

        private void CleanForm()
        {
            ActionControl.ClearTextBoxes(txtName);
            ActionControl.ClearTextBoxes(txtCreditCard);
            cbStatus.SelectedIndex = 0;
            cbType.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            mTxtIdentification.Text = null;
        }

        private async Task SaveEntity()
        {
            var Customer = new Customer()
            {
                Name = txtName.Text.Trim(),
                Identification = mTxtIdentification.Text.Trim(),
                CreditCard = txtCreditCard.Text.Trim(),
                CreditLimit = (int)numericUpDown1.Value,
                PersonType = cbType.Text,
                Status = cbStatus.Text
            };
            await _Customer.Add(Customer);
            await _Customer.SaveAsync();
        }
        private async Task UpdateEntity()
        {
            _entityToEdit.Name = txtName.Text.Trim();
            _entityToEdit.Identification = mTxtIdentification.Text.Trim();
            _entityToEdit.CreditCard = txtCreditCard.Text.Trim();
            _entityToEdit.CreditLimit = (int)numericUpDown1.Value;
            _entityToEdit.PersonType = cbType.Text;
            _entityToEdit.Status = cbStatus.Text;

            _Customer.Update(_entityToEdit);
            await _Customer.SaveAsync();
        }

        private bool IsFormValid()
        {
            return txtName.Text.Trim().Length > 0 && txtName.Text.Trim().Length <= 100
                && Identification.Validate(mTxtIdentification.Text.Trim())
                && txtCreditCard.Text.Trim().Length > 0 && txtCreditCard.Text.Trim().Length <= 20;
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
            await _Customer.Delete(Id);
            await _Customer.SaveAsync();
        }

        private async void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

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

                _entityToEdit = await _Customer.Get(GetIdCurrentRow());
                txtName.Text = _entityToEdit.Name;
                mTxtIdentification.Text = _entityToEdit.Identification;
                txtCreditCard.Text = _entityToEdit.CreditCard;
                numericUpDown1.Value = _entityToEdit.CreditLimit;
                cbType.SelectedItem = _entityToEdit.PersonType;
                cbStatus.SelectedItem = _entityToEdit.Status;
                
            }

            DeleteBtn.Enabled = !DeleteBtn.Enabled;
            dataGridView1.Enabled = !dataGridView1.Enabled;
            
            _editionMode = !_editionMode;
        }

        private int GetIdCurrentRow()
        {
            return int.TryParse(dataGridView1.CurrentRow.Cells[nameof(Customer.Id)].Value.ToString(), out int id) ? id : 0;
        }

        private async void EditBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            await EditionModeToggle();
        }

    }
}
