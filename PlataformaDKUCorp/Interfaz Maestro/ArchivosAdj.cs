using PlataformaDKUCorp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlataformaDKUCorp.Interfaz_Maestro
{
    public partial class ArchivosAdj : Form
    {
        public ArchivosAdj()
        {
            InitializeComponent();
        }

        private void ArchivosAdj_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    //Conexion_a_BD.ConexionBD.ObtenerConexion();
            //    //SqlCommand comando = new SqlCommand("SP_BuscarSimulaciones", Conexion_a_BD.ConexionBD.conexion);
            //    //comando.CommandType = CommandType.StoredProcedure;
            //    ////comando.Parameters.AddWithValue("sec", SqlDbType.VarChar).Value = Seccion;
            //    //comando.Parameters.AddWithValue("clase", SqlDbType.VarChar).Value = NombreClase.Text;
            //    //SqlDataAdapter sda = new SqlDataAdapter(comando);
            //    //DataTable dt = new DataTable();
            //    //sda.Fill(dt);

            //    using (Model.DkuCorpEntities db = new Model.DkuCorpEntities())
            //    {
            //        var lst = from d in db.Archivos
            //                  select new { d.archivoID, d.archivoNom, d.nomReal };

            //        var tempLst = lst.ToArray();

            //        for (int countButton = 0; countButton < tempLst.Count();)// for each
            //        {
            //            Button temp = new Button();
            //            Console.WriteLine(countButton);
            //            temp.Height = 66;
            //            temp.Width = 335;
            //            temp.Location = new Point(33, 19 + y * countButton);
            //            temp.Name = "btnDoc" + (countButton + 1).ToString();
            //            temp.Text = tempLst[countButton].archivoNom.ToString();
            //            //temp.Parent = this;
            //            temp.Click += (sdr, ev) => BtnDocExistenteComun_Click(sdr, ev, tempLst[countButton - 2].nomReal);
            //            this.gb1.Controls.Add(temp);
            //            countButton++;

            //        }

            //    } */


            //    // Agregar los botones dinamicamente


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al extraer archivos de la Base de Datos\n" +
            //        "Contactar al Staff de IT mas cercano\n" + ex.Message);
            //}

            RefrescarListBox();
        }

        public void BtnDocExistenteComun_Click(object sender, EventArgs e, string archnomReal)
        {
            Console.WriteLine(archnomReal);
            //Guardar archivo
            //((Button)sender).
            //Presentar archivo en aplicacion word o excel o cualquier otro
            //Process.Start(AppDomain.CurrentDomain.BaseDirectory + "temp\\" + /* nomReal */);
        }

        private void button1_Click(object sdr, EventArgs e)
        {
            AgregarArchivo frm = new AgregarArchivo();
            frm.ShowDialog();
            RefrescarListBox();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void RefrescarListBox()
        {
            if(this.lstBox1.Items.Count == 0)
            {
                using (Model.DkuCorpEntities db = new Model.DkuCorpEntities())
                {
                    var lst = from d in db.Archivos
                              select new { d.archivoNom };

                    var tempLst = lst.ToArray();


                    foreach (var txt in tempLst)
                    {
                        lstBox1.Items.Add(txt.archivoNom);
                    }

                }
            }
            else
            {
                for(int i=0;i < lstBox1.Items.Count;i++)
                {
                    lstBox1.Items.RemoveAt(i);
                }
                using (Model.DkuCorpEntities db = new Model.DkuCorpEntities())
                {
                    var lst = from d in db.Archivos
                              select new { d.archivoNom };

                    var tempLst = lst.ToArray();


                    foreach (var txt in tempLst)
                    {
                        lstBox1.Items.Add(txt.archivoNom);
                    }

                }
            }
        }
    }
}
