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
    public partial class BorrarUsuario : Form
    {
        public BorrarUsuario()
        {
            InitializeComponent();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if(TxtNombreBorrar.Text == String.Empty)
            {
                MessageBox.Show("Campo \"Nombre de Usuario\" vacío!", "ERROR");
            }
            else
            {
                try
                {
                    Gestion_de_Usuario.UsuarioDAL.BorrarUsuario(TxtNombreBorrar.Text);
                    TxtNombreBorrar.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Usuario no existente, intente de nuevo");
                    TxtNombreBorrar.Clear();
                }
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
