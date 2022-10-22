using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp.Gestion_de_Usuario
{
    internal class UsuarioDAL
    {
        public static void AgregarUsuario(string userNom, string contra, string tipoUser)
        {
            try
            {
                Conexion_a_BD.ConexionBD.ObtenerConexion(); //Estableciendo conexión con la base de datos
                SqlCommand comando = new SqlCommand("SP_Agregar_Usuario", Conexion_a_BD.ConexionBD.conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("usernom",SqlDbType.VarChar).Value = userNom;
                comando.Parameters.AddWithValue("contra", SqlDbType.VarChar).Value = contra;
                comando.Parameters.AddWithValue("tipouser", SqlDbType.VarChar).Value = tipoUser;

                comando.ExecuteReader();
                MessageBox.Show("Usuario agregado exitosamente.");
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

        //Función para ingresar inventario
        public static void ModificarUsuario(string campoEdit, string usernom, string campoEditado)
        {
            try
            {
                Conexion_a_BD.ConexionBD.ObtenerConexion();
                SqlCommand comando2 = new SqlCommand("SP_ModificarUsuario", Conexion_a_BD.ConexionBD.conexion);
                comando2.CommandType = CommandType.StoredProcedure;
                comando2.Parameters.AddWithValue("Campo_a_Editar", SqlDbType.VarChar).Value = campoEdit;
                comando2.Parameters.AddWithValue("usernom", SqlDbType.VarChar).Value = usernom;
                comando2.Parameters.AddWithValue("Campo_Editado", SqlDbType.VarChar).Value = campoEditado;
                comando2.ExecuteReader();
                MessageBox.Show("Usuario actualizado exitosamente.");
            }
            catch (Exception erro) //Excepción que nos indicará si hay un error, mostraría el siguiente mensaje
            {
                MessageBox.Show("No se pudo modificar el Usuaario debido a un error.", erro.Message);
            }
            finally
            {
                Conexion_a_BD.ConexionBD.CerrarConexion();
            }
        }

        public static void BorrarUsuario(string usernom)
        {
            try
            {
                Conexion_a_BD.ConexionBD.ObtenerConexion();
                SqlCommand comando3 = new SqlCommand("SP_Borrar", Conexion_a_BD.ConexionBD.conexion);
                comando3.CommandType = CommandType.StoredProcedure;
                comando3.Parameters.AddWithValue("usernom", SqlDbType.VarChar).Value = usernom;
                comando3.ExecuteReader();
                MessageBox.Show("Usuario borrado exitosamente.");
            }
            catch (Exception erro) //Excepción que nos indicará si hay un error, mostraría el siguiente mensaje
            {
                MessageBox.Show("No se pudo borrar el usuario debido a un error.", erro.Message);
            }
            finally
            {
                Conexion_a_BD.ConexionBD.CerrarConexion();
            }
        }

        public static void ShowDGView(DataGridView dgv)
        {
            try
            {
                Conexion_a_BD.ConexionBD.ObtenerConexion();
                SqlCommand comando4 = new SqlCommand("SELECT * FROM Usuario", Conexion_a_BD.ConexionBD.conexion);
                SqlDataAdapter sda = new SqlDataAdapter(comando4);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception erro) //Excepción que nos indicará si hay un error, mostraría el siguiente mensaje
            {
                MessageBox.Show("No se pudo cargar la tabla de Usuario", erro.Message);
            }
            finally
            {
                Conexion_a_BD.ConexionBD.CerrarConexion();
            }
        }

    }
}
