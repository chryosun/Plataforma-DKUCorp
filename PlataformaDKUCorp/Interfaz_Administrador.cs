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
    public partial class Interfaz_Administrador : Form
    {
        public Interfaz_Administrador()
        {
            InitializeComponent();
        }

        private void Interfaz_Administrador_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionUsuarios form_usuarios = new GestionUsuarios();
            form_usuarios.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
