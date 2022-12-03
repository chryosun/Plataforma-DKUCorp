using PlataformaDKUCorp.Creacion_de_Cuestionario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp.Interfaz_Alumno
{
    public partial class MenuAlumno : Form
    {
        public Form RefToLogin { get; set; }

        public MenuAlumno(Form Pariente)
        {
            InitializeComponent();
            RefToLogin = Pariente;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClase_Click(object sender, EventArgs e)
        {
            var asig = new asigAlumno(this);
            this.Hide();
            asig.ShowDialog();
            this.Show();
        }
    }
}
