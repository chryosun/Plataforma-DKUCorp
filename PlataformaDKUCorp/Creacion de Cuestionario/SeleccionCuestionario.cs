using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp.Creacion_de_Cuestionario
{
    public partial class SeleccionCuestionario : Form
    {
        public SeleccionCuestionario()
        {
            InitializeComponent();
        }

        private void BtnNuevoCuest_Click(object sender, EventArgs e)
        {
            Creacion_de_Cuestionario.AgregarCuestionario formCuest = new AgregarCuestionario();
            formCuest.ShowDialog();
        }
    }
}
