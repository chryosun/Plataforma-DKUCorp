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
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            AgregarUsuario frmAgregar = new AgregarUsuario();
            frmAgregar.ShowDialog();
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            BorrarUsuario frmBorrar = new BorrarUsuario();
            frmBorrar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gestion_de_Usuario.ModificarUsuario frmModificar = new Gestion_de_Usuario.ModificarUsuario();
            frmModificar.ShowDialog();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            Gestion_de_Usuario.UsuarioDAL.ShowDGView(dgvUsuario);
        }
    }
}
