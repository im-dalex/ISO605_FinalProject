﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeteoRentCar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OpenRentasForm_Click(object sender, EventArgs e)
        {
            var form = new Rents();
            form.Show();
        }
    }
}