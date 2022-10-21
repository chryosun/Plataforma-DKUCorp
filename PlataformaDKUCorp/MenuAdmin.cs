using System;
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
        //Referencia de instancia del frm Login
        public Form RefToLogin { get; set; }

        public MenuAdmin(Form frm)
        {
            RefToLogin = frm; 
            InitializeComponent();
        }

        private void Btn_GtestionUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionUsuarios formPrueba = new GestionUsuarios();
            formPrueba.ShowDialog();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            RefToLogin.Show();
            this.Close();
        }
    }
}
