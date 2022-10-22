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
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void ModificarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            Gestion_de_Usuario.UsuarioDAL.ModificarUsuario(TxtCampoMod.Text, TxtNombreMod.Text, TxtNuevoCampoMod.Text);
            TxtCampoMod.Clear();
            TxtNombreMod.Clear();
            TxtNuevoCampoMod.Clear();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
