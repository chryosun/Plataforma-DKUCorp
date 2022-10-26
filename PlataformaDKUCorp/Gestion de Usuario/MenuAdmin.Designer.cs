namespace PlataformaDKUCorp
{
    partial class MenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_GtestionUsuario = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde aqui podra elegir a que tabla de la base de datos podra manejar";
            // 
            // Btn_GtestionUsuario
            // 
            this.Btn_GtestionUsuario.Location = new System.Drawing.Point(276, 221);
            this.Btn_GtestionUsuario.Name = "Btn_GtestionUsuario";
            this.Btn_GtestionUsuario.Size = new System.Drawing.Size(133, 29);
            this.Btn_GtestionUsuario.TabIndex = 2;
            this.Btn_GtestionUsuario.Text = "Gestion de Usuarios";
            this.Btn_GtestionUsuario.UseVisualStyleBackColor = true;
            this.Btn_GtestionUsuario.Click += new System.EventHandler(this.Btn_GtestionUsuario_Click);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Location = new System.Drawing.Point(513, 347);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(133, 29);
            this.BtnCerrarSesion.TabIndex = 3;
            this.BtnCerrarSesion.Text = "Cerrar Sesion";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 417);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.Btn_GtestionUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_GtestionUsuario;
        private System.Windows.Forms.Button BtnCerrarSesion;
    }
}