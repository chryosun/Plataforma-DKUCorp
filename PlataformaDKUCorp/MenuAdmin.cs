﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void Btn_GtestionUsuario_Click(object sender, EventArgs e)
        {
            GestionUsuarios formPrueba = new GestionUsuarios();
            formPrueba.Show();
        }
    }
}