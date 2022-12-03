using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp.Gestion_de_Usuario
{
    public partial class ModificarUsuario : Form
    {

        List<Gestion_de_Usuario.Datos> datos = new List<Gestion_de_Usuario.Datos>()
        {
            new Gestion_de_Usuario.Datos {Id = "Usuario",Nombre = "Nombre de Usuario"},
            new Gestion_de_Usuario.Datos {Id = "Contraseña",Nombre = "Contraseña"},
            new Gestion_de_Usuario.Datos {Id = "TipoUsuario",Nombre = "Tipo de Usuario"}
        };

        public ModificarUsuario()
        {
            InitializeComponent();
            cmbCampo.DataSource = datos;
            cmbCampo.ValueMember = "Id";
            cmbCampo.DisplayMember = "Nombre";
            cmbCampo.SelectedIndex = -1;
            //mostrar propiedad cmb.DropDownStyle = DropDownList
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            if(cmbCampo.SelectedIndex == -1 || TxtNombreMod.Text == String.Empty || TxtNuevoCampoMod.Text == String.Empty)
            {
                MessageBox.Show("Llenar los campos que esten vacíos!", "ERROR");
            }
            else
            {
                Gestion_de_Usuario.UsuarioDAL.ModificarUsuario(cmbCampo.SelectedValue.ToString(), TxtNombreMod.Text, TxtNuevoCampoMod.Text);
                cmbCampo.SelectedIndex = -1;
                TxtNombreMod.Clear();
                TxtNuevoCampoMod.Clear();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
