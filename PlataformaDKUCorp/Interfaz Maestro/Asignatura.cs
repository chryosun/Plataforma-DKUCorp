using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PlataformaDKUCorp.Creacion_de_Cuestionario
{
    public partial class Asignatura : Form
    {
        public Form RefToMenuMaestro { get; set; }
        public string Clase { get; set; }
        public string Seccion { get; set; }


        public Asignatura(Form refToMenuMaestro, string clase, string seccion)
        {
            InitializeComponent();
            RefToMenuMaestro = refToMenuMaestro;
            Clase = clase;
            Seccion = seccion;
        }

        private void BtnNuevoCuest_Click(object sender, EventArgs e)
        {
            Creacion_de_Cuestionario.DatosCuestionario formCuest = new DatosCuestionario();
            formCuest.ShowDialog();
        }

        private void NombreClase_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            RefToMenuMaestro.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Asignatura_Load(object sender, EventArgs e)
        {
            this.Text = Clase;
            NombreClase.Text = Clase + " " + Seccion;
            int count = NombreClase.Text.Split(' ').Count();
            //int paddingbottom = 20;
            int y = 35;

            try
            {
                Conexion_a_BD.ConexionBD.ObtenerConexion();
                SqlCommand comando = new SqlCommand("SP_BuscarCuestionarios", Conexion_a_BD.ConexionBD.conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("sec", SqlDbType.VarChar).Value = NombreClase.Text.Split(' ')[count - 1];
                comando.Parameters.AddWithValue("clase", SqlDbType.VarChar).Value = this.Text;
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Agregar los botones dinamicamente

                for (int countButton = 0; countButton <= dt.Rows.Count; countButton++)
                {
                    Button temp = new Button();

                    temp.Height = 30;
                    temp.Width = 240;
                    temp.Location = new Point(84, 41 + y * countButton);
                    temp.Name = "btnCuestionario" + (countButton + 1).ToString();
                    temp.Text = dt.Rows[countButton][0].ToString();
                    temp.Click += new EventHandler(BtnCuestExistenteComun_Click);
                    Controls.Add(temp);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conseguir información de la Base de Datos\n" +
                    "Contactar al Staff de IT mas cercano\n" + ex.Message);
            }
            finally
            {
                Conexion_a_BD.ConexionBD.CerrarConexion();
            }
        }

        private void BtnCuestExistenteComun_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion_a_BD.ConexionBD.ObtenerConexion();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand("SELECT CuestNom, NumPreguntas,CuestNota,CuestDesc FROM Cuestionario" +
                    "WHERE CuestNom = '" + ((Button)sender).Text + "'", Conexion_a_BD.ConexionBD.conexion);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                DatosCuestionario dtCuest = new DatosCuestionario();

                //Busca los controles en un punto especifico del form e ingresamos a su propiedad
                //Text una de las celdas conseguida del resultado del SELECT

                dtCuest.GetChildAtPoint(new Point(33, 84)).Text = dt.Rows[0][0].ToString();
                dtCuest.GetChildAtPoint(new Point(33, 135)).Text = dt.Rows[0][1].ToString();
                dtCuest.GetChildAtPoint(new Point(33, 185)).Text = dt.Rows[0][2].ToString();
                dtCuest.GetChildAtPoint(new Point(33, 237)).Text = dt.Rows[0][3].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conseguir información de la Base de Datos\n" +
                    "Contactar al Staff de IT mas cercano\n" + ex.Message);
            }
            finally
            {
                Conexion_a_BD.ConexionBD.CerrarConexion();
            }

        }
    } 
}

