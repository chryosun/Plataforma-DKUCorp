using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp.Conexion_a_BD
{
    internal class ConexionBD
    {
        public static SqlConnection conexion = new SqlConnection("Data source = localhost;" +
            "database = DkuCorp; Integrated Security = True");

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir conexión con la base de datos: \n" + ex.Message);
                return null;
            }
        }

        public static void CerrarConexion()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
                else
                {
                    MessageBox.Show("La conexión no está abierta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar:\n" + ex.Message);
            }
        }

        //metodo LogIn que valida las credenciales puestas por el usuario
        /*public static bool LogIn(String usuario, string contraseña)
        {
            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("SELECT Usuario.UsuarioId,Usuario.UsuarioContraseña,Usuario.TipoUsuario FROM Usuario WHERE Usuario.UsuarioId = \'" + usuario + "\' and Usuario.UsuarioContraseña = \'" + contraseña + "\'", conexion);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][2].ToString() == "A")
                    {

                    }

                    else if (dt.Rows[0][1].ToString() == "M")
                    {
                        if (dt.Rows[0][2].ToString() == "True") return (int)dt.Rows[0][3];

                        else
                        {
                            MessageBox.Show("Usuario o contraseña inválido.");
                            return -5;
                        }
                    }
                    else if (dt.Rows[0][1].ToString() == "E")
                }
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña inválida");
            }
            finally
            {
                conexion.Close();
            }
        }*/
    }
}
