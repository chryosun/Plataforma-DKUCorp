using PlataformaDKUCorp.Creacion_de_Cuestionario;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            RefToLogin.Show();
            this.Close();
        }

        private void MenuMaestro_Load(object sender, EventArgs e)
        {
            /* CODIGO DESACTUALIZADO EN DESUSO
            try
            {
                
                 * SqlCommand comando = new SqlCommand("SP_BuscarClases", Conexion_a_BD.ConexionBD.conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("usernom", SqlDbType.VarChar).Value = Sesion.NombreUsuario;
                comando.Parameters.AddWithValue("tipoUsuario", SqlDbType.Char).Value = Sesion.TipoUsuario;
                SqlDataAdapter sda = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                

                // Agregar los botones dinamicamente

                for (int countButton = 0; countButton <= dt.Rows.Count - 1; countButton++)
                {
                    Button temp = new Button();

                    temp.Height = 30;
                    temp.Width = 256;
                    temp.Location = new Point(28, 36 + y * countButton);
                    temp.Name = "btnClase" + (countButton + 1).ToString();
                    temp.Text = (dt.Rows[countButton][0] + "_" + dt.Rows[countButton][1]).ToString();
                    temp.Click += new EventHandler(BtnClaseExistenteComun_Click);
                    this.groupBox1.Controls.Add(temp);


                }
                 * 





            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conseguir información de la Base de Datos\n" +
                    "Contactar al Staff de IT mas cercano\n" + ex.Message);
            }
            finally
            {
                Conexion_a_BD.ConexionBD.CerrarConexion();
            }
            
            FIN CODIGO DESACTUALIZADO   */
        }

        /*private void BtnClaseExistenteComun_Click(object sender, EventArgs e)
        {
            try
            {
                Asignatura asig = new Asignatura(this, ((Button)sender).Text.Split('_')[0], ((Button)sender).Text.Split('_')[1]);
                asig.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conseguir información de la Base de Datos\n" +
                    "Contactar al Staff de IT mas cercano\n" + ex.Message);
            }
            finally
            {
                Conexion_a_BD.ConexionBD.CerrarConexion();
            }

        }
        */

        private void btnClase_Click(object sender, EventArgs e)
        {
            var asig = new Asignatura(this);
            this.Hide();
            asig.ShowDialog();
            this.Show();

        }

    }
}
