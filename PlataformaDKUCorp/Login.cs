using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion_a_BD.ConexionBD.ObtenerConexion(); //Estableciendo conexión con la base de datos
                SqlCommand comando = new SqlCommand("SP_Login", Conexion_a_BD.ConexionBD.conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("usernom", SqlDbType.VarChar).Value = txtUsuario.Text;
                comando.Parameters.AddWithValue("contra", SqlDbType.VarChar).Value = txtContra.Text;
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    txtUsuario.Clear();
                    txtContra.Clear();
                    
                    if (dt.Rows[0][1].ToString() == "A")
                    {
                        MenuAdmin menufrm = new MenuAdmin(this);
                        menufrm.Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "M")
                    {
                        MenuMaestro frmmaster = new MenuMaestro(this);
                        frmmaster.Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "E")
                    {

                    }
                    this.Hide();
                }
                else
                {
                    txtContra.Clear();
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception erro) //Excepción que nos indicará si hay un error, mostraría el siguiente mensaje
            {
                MessageBox.Show("No se pudo ingresar el registro debido a un error.", erro.Message);
            }
            finally
            {
                Conexion_a_BD.ConexionBD.CerrarConexion(); //Cerrando conexión con la base de datos
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTxt.ConfTxt(e);
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesTxt.ConfTxt(e);
        }
    }
}
