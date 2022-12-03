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

        public DatosSim(Form RefToClase,double presupuesto=0, double precioProd=0, 
            double maqValor=0,bool doExist = false, string idSim = "", string SimNom = "",string numFases = "", string SimNota = "", string SimDesc = "")
        {
            InitializeComponent();
            this.DoExist = doExist;
            this.lblSimID.Text = idSim=="" ? "__": idSim;
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
            this.txtPresupuesto.Text= presupuesto.ToString();
            this.txtPrecioProd.Text = precioProd.ToString();
            this.txtMaqValor.Text = maqValor.ToString();
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
            else if(txtPresupuesto.Text == String.Empty)
            {
                MessageBox.Show("No se ingreso datos en el cuadro de \'Presupuesto de Empresa en Lps.:\'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtPrecioProd.Text == String.Empty)
            {
                MessageBox.Show("No se ingreso datos en el cuadro de \'Precio de Productos en Lps.:\'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txtMaqValor.Text == String.Empty)
            {
                MessageBox.Show("No se ingreso datos en el cuadro de \'Valor de Maquinaria en Lps.:\'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Conexion_a_BD.ConexionBD.ObtenerConexion();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    //Hacer update a un registro de la Simulacion
                    
                    if(!this.DoExist)
                    {
                        var cmd = new SqlCommand("INSERT INTO Simulacion VALUES ('" + TxtNombreSim.Text.ToString() +
                        "', '" + TxtPreguntaSim.Text.ToString() + "', '" + TxtDescSim.Text.ToString() +
                        "', " + TxtPuntuacionSim.Text.ToString() + ", " + txtPresupuesto.Text.ToString() +
                        ", " + txtPrecioProd.Text.ToString() + ", " + txtMaqValor.Text.ToString() + ",null,null, 'FIN101', '" + Sesion.NombreUsuario.ToString() + "' )",ConexionBD.conexion);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se agrego los detalles de la nueva simulación exitosamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnAgregar.Enabled = true;
                    }
                    else
                    {
                        var cmd = new SqlCommand("UPDATE Simulacion SET SimNom = '" + TxtNombreSim.Text.ToString() +
                        "' ,NumRondas = '" + TxtPreguntaSim.Text.ToString() + "' ,SimDesc = '" + TxtDescSim.Text.ToString() +
                        "' ,SimNota = " + TxtPuntuacionSim.Text.ToString() + ", PresupuestoInit = " + txtPresupuesto.Text.ToString() +
                        ", PrecioProdInit = " + txtPrecioProd.Text.ToString() + ", MaqValor =  " + txtMaqValor.Text.ToString() + ",ClaseID = 'FIN101', Autor = '" + Sesion.NombreUsuario.ToString() + "' WHERE SimID = '" + lblSimID.Text.ToString() + "'", ConexionBD.conexion);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se actualizó los detalles de la Simulación, exitosamente", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


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

        private void BtnIniciarSim_Click(object sender, EventArgs e)
        {
            using(Model.DkuCorpEntities db = new Model.DkuCorpEntities())
            {
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
