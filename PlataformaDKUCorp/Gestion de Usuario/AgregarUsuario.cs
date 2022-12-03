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
            if(TxtNombreAgregar.Text.Length == 0 || TxtNombreAgregar.Text.Length > 30)
            {
                MessageBox.Show("Error: Campo de texto \'Nombre de Usuario\' vacío o superando el limite de 30 caracteres", "ERROR");
            }
            else if(TxtContraseñaAgregar.Text.Length < 5 || TxtContraseñaAgregar.Text.Length > 10)
            {
                MessageBox.Show("Error: Campo de texto \'Contraseña\' vacío o superando el limite de rango de 5-10 caracteres", "ERROR");
            }
            else if(cmbTipoUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Error: La caja de opciones de \'Tipo de Usuario\' sin ninguna, opción seleccionada\n" +
                    "Elija una opcion de la caja de opciones", "ERROR");
            }
            else
            {
                Gestion_de_Usuario.UsuarioDAL.AgregarUsuario(TxtNombreAgregar.Text, TxtContraseñaAgregar.Text, cmbTipoUsuario.SelectedValue.ToString());
                TxtNombreAgregar.Clear();
                TxtContraseñaAgregar.Clear();
                cmbTipoUsuario.SelectedIndex = -1;
            }

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
