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

namespace PlataformaDKUCorp
{
    public partial class MenuMaestro : Form
    {
        public Form RefToLogin { get; set; }
        public MenuMaestro(Form frm)
        {
            RefToLogin = frm;
            InitializeComponent();
        }

        private void BtnEleccion1_Click(object sender, EventArgs e)
        {
            Asignatura frmClase = new Asignatura(this, BtnEleccion1.Text.Split('_')[0], BtnEleccion1.Text.Split('_')[1]);
            this.Hide();
            frmClase.Show();
        }
    }
}
