﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            PrincipalMDI principal = new PrincipalMDI();
            principal.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
