using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Creacion_de_Cuestionario.AgregarCuestionario formCuest = new AgregarCuestionario();
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
            int paddingbottom = 20;
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
                    Controls.Add(new Button
                    {
                        Height = 30,
                        Width = 240,
                        Location = new Point(84, 41 + y * countButton),
                        Name = "btnCuestionario" + (countButton + 1).ToString(),
                        Text = dt.Rows[countButton][0].ToString(),
                        //Click += new System.EventHandler( ),
                     });
                }
            }
            catch(Exception e)
            {

            }
        }

        private void BtnCuestionarioComun_Click(object sender, EventArgs e)
        {

        }

    }
}

