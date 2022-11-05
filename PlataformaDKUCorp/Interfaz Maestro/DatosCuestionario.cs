using PlataformaDKUCorp.Conexion_a_BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp.Creacion_de_Cuestionario
{
    public partial class DatosCuestionario : Form
    {

        public Form RefToClase { get; set; }

        public DatosCuestionario(Form RefToClase,bool bandera,string CuestNom = "",string numPreguntas = "", string CuestNota = "", string CuestDesc = "")
        {
            InitializeComponent();
            BtnAgregar.Enabled = bandera;
            this.TxtNombreCuest.Text = CuestNom;
            this.TxtPreguntaCuest.Text = numPreguntas;
            this.TxtPuntuacionCuest.Text = CuestNota;
            this.TxtDescCuest.Text = CuestDesc;
            this.RefToClase = RefToClase;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            RefToClase.Show();
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.ObtenerConexion();

            }
            catch(Exception e)
            {
                MessageBox.Show("Error al manejar arreglos con la base de datos\nContacte al IT mas cercano","ERROR\n" + e.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
    }
}
