using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlataformaDKUCorp.Interfaz_Maestro
{
    public partial class AgregarArchivo : Form
    {
        public AgregarArchivo()
        {
            InitializeComponent();
            Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "Docs PDF (*.pdf)|*.pdf|Docs Word (*.doc,*.docx)| *.doc;*.docx|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Equals("") || txtFile.Text.Trim().Equals(""))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            byte[] file = null;
            Stream myStream = openFileDialog1.OpenFile();
            using (MemoryStream ms = new MemoryStream())
            {
                myStream.CopyTo(ms);
                file = ms.ToArray();
            }

            using (Model.DkuCorpEntities db = new Model.DkuCorpEntities())
            {
                Model.Archivo oDocument = new Model.Archivo();
                oDocument.archivoNom = txtName.Text.Trim();
                oDocument.contenido = file;
                oDocument.nomReal = openFileDialog1.SafeFileName;
                oDocument.bajoMaestro = "0101200390341";
                db.Archivos.Add(oDocument);
                db.SaveChanges();
            }

            Refrescar();
        }

        private void Refrescar()
        {

            using (Model.DkuCorpEntities db = new Model.DkuCorpEntities())
            {
                var lst = from d in db.Archivos
                          select new { d.archivoID, d.archivoNom };
                dgvLista.DataSource = lst.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvLista.Rows.Count > 0)
            {
                int id = int.Parse(dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[0].Value.ToString());

                using (Model.DkuCorpEntities db = new Model.DkuCorpEntities())
                {
                    var oDocument = db.Archivos.Find(id);

                    string path = AppDomain.CurrentDomain.BaseDirectory;
                    string folder = path + "temp\\";
                    string fullFilePath = folder + oDocument.nomReal;

                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    if (File.Exists(fullFilePath))
                        File.Delete(fullFilePath);

                    File.WriteAllBytes(fullFilePath, oDocument.contenido);

                    Process.Start(fullFilePath);
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
