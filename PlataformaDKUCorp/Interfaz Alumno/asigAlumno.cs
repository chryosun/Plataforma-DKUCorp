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
    public partial class asigAlumno : Form
    {
        public Form RefToMenu { get; set; }
        public asigAlumno(Form parMenu)
        {
            InitializeComponent();
            RefToMenu = parMenu;
            this.groupBox1.AutoSize= true;
        }

        private void asigAlumno_Load(object sender, EventArgs e)
        {
            this.NombreClase.Text = "Introducción a Contabilidad";
            using(Model.DkuCorpEntities db = new Model.DkuCorpEntities())
            {
                var lst = from d in db.Simulacions
                          select new { d.SimNom, d.NumRondas,d.PresupuestoInit,d.PrecioProdInit,d.MaqValor,d.SimNota};

                var tempLst = lst.ToArray();
                int y = 35, countButton = 0;

                foreach (var sim in tempLst)
                {
                    Button temp = new Button();

                    temp.Height = 30;
                    temp.Width = 240;
                    temp.Location = new Point(84, 41 + y * countButton);
                    temp.Name = "btnSim" + (countButton + 1).ToString();
                    temp.Text = sim.SimNom.ToString();
                    temp.Click += new EventHandler(BtnSimExistenteComun_Click);
                    this.groupBox1.Controls.Add(temp);
                    countButton++;
                }
            }
        }

        public void BtnSimExistenteComun_Click(object sender, EventArgs e)
        {
            using (Model.DkuCorpEntities db = new Model.DkuCorpEntities())
            {
                var lst = from d in db.Simulacions
                          select new { d.SimNom, d.NumRondas, d.PresupuestoInit, d.PrecioProdInit, d.MaqValor, d.SimNota };

                var tempLst = lst.ToArray();

                //Inicializar una Simulación

            }
        }
    }
}
