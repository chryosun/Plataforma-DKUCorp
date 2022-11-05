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

        public DatosCuestionario(Form RefToClase,string CuestNom = "",string numPreguntas = "", string CuestNota = "", string CuestDesc = "")
        {
            InitializeComponent();
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
    }
}
