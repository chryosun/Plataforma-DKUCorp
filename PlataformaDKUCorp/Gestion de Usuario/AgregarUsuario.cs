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
    public partial class AgregarUsuario : Form
    {
        List<Gestion_de_Usuario.Datos> datos = new List<Gestion_de_Usuario.Datos>()
        {
            new Gestion_de_Usuario.Datos {Id = "A",Nombre = "Administrador"},
            new Gestion_de_Usuario.Datos {Id = "M",Nombre = "Maestro"},
            new Gestion_de_Usuario.Datos {Id = "E",Nombre = "Estudiante"}
        };


        public AgregarUsuario()
        {
            InitializeComponent();
            cmbTipoUsuario.DataSource = datos;
            cmbTipoUsuario.ValueMember = "Id";
            cmbTipoUsuario.DisplayMember = "Nombre";
            cmbTipoUsuario.SelectedIndex = -1;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Gestion_de_Usuario.UsuarioDAL.AgregarUsuario(TxtNombreAgregar.Text, TxtContraseñaAgregar.Text, cmbTipoUsuario.SelectedValue.ToString());
            TxtNombreAgregar.Clear();
            TxtContraseñaAgregar.Clear();
            cmbTipoUsuario.SelectedIndex = -1;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
