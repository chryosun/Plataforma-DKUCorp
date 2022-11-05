namespace PlataformaDKUCorp.Creacion_de_Cuestionario
{
    partial class Asignatura
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNuevoCuest = new System.Windows.Forms.Button();
            this.NombreClase = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(65, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuestionarios Disponibles";
            // 
            // BtnNuevoCuest
            // 
            this.BtnNuevoCuest.Location = new System.Drawing.Point(12, 387);
            this.BtnNuevoCuest.Name = "BtnNuevoCuest";
            this.BtnNuevoCuest.Size = new System.Drawing.Size(248, 40);
            this.BtnNuevoCuest.TabIndex = 4;
            this.BtnNuevoCuest.Text = "Nuevo Cuestionario \r\n+ ";
            this.BtnNuevoCuest.UseVisualStyleBackColor = true;
            this.BtnNuevoCuest.Click += new System.EventHandler(this.BtnNuevoCuest_Click);
            // 
            // NombreClase
            // 
            this.NombreClase.AutoSize = true;
            this.NombreClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreClase.Location = new System.Drawing.Point(33, 22);
            this.NombreClase.Name = "NombreClase";
            this.NombreClase.Size = new System.Drawing.Size(278, 33);
            this.NombreClase.TabIndex = 3;
            this.NombreClase.Text = "<placeholderNom>";
            this.NombreClase.Click += new System.EventHandler(this.NombreClase_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(560, 382);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 45);
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Asignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 439);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnNuevoCuest);
            this.Controls.Add(this.NombreClase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Asignatura";
            this.Text = "<placeholderNom>";
            this.Load += new System.EventHandler(this.Asignatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNuevoCuest;
        private System.Windows.Forms.Label NombreClase;
        private System.Windows.Forms.Button btnRegresar;
    }
}