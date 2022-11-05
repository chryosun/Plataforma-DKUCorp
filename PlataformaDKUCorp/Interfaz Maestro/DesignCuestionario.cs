using System;
using System.Windows.Forms;


namespace PlataformaDKUCorp
{
    public partial class DesignCuestionario : Form
    {
        public DesignCuestionario()
        {
            InitializeComponent();
        }

        private void tabPlus_Enter(object sender, EventArgs e)
        {
            //this.Parent.(new TabPage { Text = " [ " + (Int32.Parse(Ta) - 1).ToString() + " ] "})
            //Crear una tabpage y saber en que container estoy en este scope
        }

        private void txtOp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (rbOp1.Text.Length > 3)
                {
                    rbOp1.Text = "1) ";
                }
                rbOp1.Text += txtOp1.Text;
            }
        }

        private void txtOp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (rbOp2.Text.Length > 3)
                {
                    rbOp2.Text = "2) ";
                }
                rbOp2.Text += txtOp2.Text;
            }
        }

        private void txtOp3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (rbOp3.Text.Length > 3)
                {
                    rbOp3.Text = "3) ";
                }
                rbOp3.Text += txtOp3.Text;
            }
        }

        private void txtOp4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (rbOp4.Text.Length > 3)
                {
                    rbOp4.Text = "4) ";
                }
                rbOp4.Text += txtOp4.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tabControl.TabPages.Add( new TabPage() { })
            //pasar atributos de la clase a la TabPage
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TabPage temp = new TabPage();
            temp.Text = "[" + (this.tabControl.TabPages.Count + 1).ToString() + "]";
            //
            // txtPregunta
            //
            RichTextBox txtPregunta = new RichTextBox();
            txtPregunta.Location = new System.Drawing.Point(35, 45);
            txtPregunta.Name = "txtPregunta";
            txtPregunta.Size = new System.Drawing.Size(539, 157);
            txtPregunta.TabIndex = 10;
            txtPregunta.Text = "";

            //
            // rbOp1
            //
            RadioButton rbOp1 = new RadioButton();
            rbOp1.AutoSize = true;
            rbOp1.Location = new System.Drawing.Point(35, 257);
            rbOp1.Name = "rbOp1";
            rbOp1.Size = new System.Drawing.Size(37, 17);
            rbOp1.TabIndex = 11;
            rbOp1.TabStop = true;
            rbOp1.Text = "1) ";
            rbOp1.UseVisualStyleBackColor = true;

            //
            // txtOp1
            //
            TextBox txtOp1 = new TextBox();
            txtOp1.Location = new System.Drawing.Point(35, 279);
            txtOp1.Name = "txtOp1";
            txtOp1.Size = new System.Drawing.Size(252, 20);
            txtOp1.TabIndex = 12;
            txtOp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtOp1_KeyPress);

            //
            // rbOp2
            //
            rbOp2 = new RadioButton();
            rbOp2.AutoSize = true;
            rbOp2.Location = new System.Drawing.Point(35, 313);
            rbOp2.Name = "rbOp2";
            rbOp2.Size = new System.Drawing.Size(37, 17);
            rbOp2.TabIndex = 13;
            rbOp2.TabStop = true;
            rbOp2.Text = "2) ";
            rbOp2.UseVisualStyleBackColor = true;

            // 
            // txtOp2
            //
            txtOp2 = new TextBox();
            txtOp2.Location = new System.Drawing.Point(36, 335);
            txtOp2.Name = "txtOp2";
            txtOp2.Size = new System.Drawing.Size(251, 20);
            txtOp2.TabIndex = 14;
            txtOp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtOp2_KeyPress);
            
            // 
            // rbOp3
            // 
            rbOp3 = new RadioButton();
            rbOp3.AutoSize = true;
            rbOp3.Location = new System.Drawing.Point(36, 372);
            rbOp3.Name = "rbOp3";
            rbOp3.Size = new System.Drawing.Size(37, 17);
            rbOp3.TabIndex = 15;
            rbOp3.TabStop = true;
            rbOp3.Text = "3) ";
            rbOp3.UseVisualStyleBackColor = true;
            // 
            // txtOp3
            //
            txtOp3 = new TextBox();
            txtOp3.Location = new System.Drawing.Point(36, 393);
            txtOp3.Name = "txtOp3";
            txtOp3.Size = new System.Drawing.Size(251, 20);
            txtOp3.TabIndex = 16;
            txtOp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtOp3_KeyPress);
            // 
            // rbOp4
            //
            rbOp4 = new RadioButton();
            rbOp4.AutoSize = true;
            rbOp4.Location = new System.Drawing.Point(35, 432);
            rbOp4.Name = "rbOp4";
            rbOp4.Size = new System.Drawing.Size(37, 17);
            rbOp4.TabIndex = 17;
            rbOp4.TabStop = true;
            rbOp4.Text = "4) ";
            rbOp4.UseVisualStyleBackColor = true;
            // 
            // txtOp4
            // 
            txtOp4 = new TextBox();
            txtOp4.Location = new System.Drawing.Point(35, 454);
            txtOp4.Name = "txtOp4";
            txtOp4.Size = new System.Drawing.Size(252, 20);
            txtOp4.TabIndex = 18;
            txtOp4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtOp4_KeyPress);
            // 
            // btnGuardar
            // 
            btnGuardar = new Button();
            btnGuardar.Location = new System.Drawing.Point(825, 437);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(189, 37);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar Cambios";
            btnGuardar.UseVisualStyleBackColor = true;

            this.tabControl.TabPages.Add(temp);
            temp.Controls.Add(txtPregunta);
            temp.Controls.Add(rbOp1);
            temp.Controls.Add(txtOp1);
            temp.Controls.Add(txtOp2);
            temp.Controls.Add(rbOp2);
            temp.Controls.Add(txtOp3);
            temp.Controls.Add(rbOp3);
            temp.Controls.Add(txtOp4);
            temp.Controls.Add(rbOp4);
            temp.Controls.Add(btnGuardar);

            this.tabControl.SelectedTab = temp;
        }
    }
}