using PlataformaDKUCorp.Conexion_a_BD;
using PlataformaDKUCorp.Interfaz_Alumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp.Creacion_de_Cuestionario
{
    public partial class DatosSim : Form
    {

        public Form RefToClase { get; set; }
        public bool DoExist { get; set; }

        public DatosSim(Form RefToClase,bool doExist = false, string idSim = "", string SimNom = "",string numFases = "", string SimNota = "", string SimDesc = "")
        {
            InitializeComponent();
            this.DoExist = doExist;
            this.lblSimID.Text = idSim;
            BtnAgregar.Enabled = !doExist;
            if (doExist)
            {
                this.Titulo.Text = "Editar Simulación";
                this.Text = "Editar Simulación";
            }
            this.TxtNombreSim.Text = SimNom;
            this.TxtPreguntaSim.Text = numFases;
            this.TxtPuntuacionSim.Text = SimNota;
            this.TxtDescSim.Text = SimDesc;
            this.RefToClase = RefToClase;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            RefToClase.Refresh();
            RefToClase.Show();
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(this.DoExist == false)
            {
                //DesignCuestionario dC = new DesignCuestionario();
                //dC.ShowDialog();

                var pr = new prueba();
                pr.Show();
                this.Hide();

            }
            else
            {
                //Traer diseño de ejercicios diferente
            }

        }

        private void DatosCuestionario_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardarConfig_Click(object sender, EventArgs e)
        {
            if(TxtNombreSim.Text == String.Empty)
            {
                MessageBox.Show("No se ingreso datos en el cuadro de \'Nombre de Simulación\'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(TxtPreguntaSim.Text == String.Empty)
            {
                MessageBox.Show("No se ingreso datos en el cuadro de \'Numero de fases del Simulador\'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(TxtPuntuacionSim.Text == String.Empty)
            {
                MessageBox.Show("No se ingreso datos en el cuadro de \'Puntuación Máxima\'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(TxtDescSim.Text == String.Empty)
            {
                MessageBox.Show("No se ingreso datos en el cuadro de \'Descripción de la Simulación:\'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Conexion_a_BD.ConexionBD.ObtenerConexion();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    //Hacer update a un registro de la Simulacion

                   var cmd = new SqlCommand("UPDATE Simulacion SET SimNom = '" + TxtNombreSim.Text.ToString() + 
                        "' ,NumFases = '" + TxtPreguntaSim.Text.ToString() + "' ,SimDesc = '" + TxtDescSim.Text.ToString() + 
                        "' ,SimNota = " + TxtPuntuacionSim.Text.ToString() + " WHERE SimID = '" + lblSimID.Text.ToString() + "'",ConexionBD.conexion);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Se actualizó los detalles de la Simulación, exitosamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar cambios a detalles de Simulación\n" +
                        "Contactar al Staff de IT mas cercano sobre el problema\n" + ex.Message);
                }
                finally
                {
                    Conexion_a_BD.ConexionBD.CerrarConexion();
                }
            }
            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
