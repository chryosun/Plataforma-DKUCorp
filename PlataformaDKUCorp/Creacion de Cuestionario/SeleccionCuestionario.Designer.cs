namespace PlataformaDKUCorp.Creacion_de_Cuestionario
{
    partial class SeleccionCuestionario
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnNuevoCuest = new System.Windows.Forms.Button();
            this.NombreClase = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(65, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 212);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuestionarios Disponibles";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cuestionario 3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(84, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cuestionario 2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cuestionario 1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnNuevoCuest
            // 
            this.BtnNuevoCuest.Location = new System.Drawing.Point(65, 323);
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
            this.NombreClase.Location = new System.Drawing.Point(83, 31);
            this.NombreClase.Name = "NombreClase";
            this.NombreClase.Size = new System.Drawing.Size(99, 33);
            this.NombreClase.TabIndex = 3;
            this.NombreClase.Text = "label1";
            // 
            // SeleccionCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnNuevoCuest);
            this.Controls.Add(this.NombreClase);
            this.Name = "SeleccionCuestionario";
            this.Text = "SeleccionCuestionario";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnNuevoCuest;
        private System.Windows.Forms.Label NombreClase;
    }
}