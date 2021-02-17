using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeteoRentCar.Views;

namespace TeteoRentCar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == string.Empty || txtPwd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ningun dato debe estar vacio. lol", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtUser.Text.Trim() != "Admin" || txtPwd.Text.Trim() != "12345")
            {
               MessageBox.Show("Los datos son incorrectos. Intentelo nuevamente", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var home = new Home();
            home.Show();

            Hide();
        }
    }
}
