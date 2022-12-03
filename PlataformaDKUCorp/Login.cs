using PlataformaDKUCorp.Interfaz_Alumno;
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
                    if (dt.Rows[0][1].ToString() == "A")
                    {
                        MenuAdmin menufrm = new MenuAdmin(this);
                        Sesion s = new Sesion(txtUsuario.Text, 'A');
                        menufrm.Show();
                        
                    }
                    else if (dt.Rows[0][1].ToString() == "M")
                    {
                        MenuMaestro frmmaster = new MenuMaestro(this);
                        Sesion s = new Sesion(txtUsuario.Text, 'M');
                        frmmaster.Show();
                        
                    }
                    else if (dt.Rows[0][1].ToString() == "E")
                    {
                        var frmEst = new MenuAlumno(this);
                        frmEst.Show();
                    }
                    this.Hide();
                    txtUsuario.Clear();
                    txtContra.Clear();
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }
            else
            {
                ValidacionesTxt.ConfTxt(e);
            }
        }
    }
}
