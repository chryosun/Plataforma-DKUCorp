﻿namespace PlataformaDKUCorp.Creacion_de_Cuestionario
{
    partial class AgregarCuestionario
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.TxtPreguntaCuest = new System.Windows.Forms.TextBox();
            this.TxtPuntuacionCuest = new System.Windows.Forms.TextBox();
            this.TxtNombreCuest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescCuest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(202, 356);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 17;
            this.BtnAgregar.Text = "Ejecutar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(57, 356);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 16;
            this.BtnRegistrar.Text = "Regresar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            // 
            // TxtPreguntaCuest
            // 
            this.TxtPreguntaCuest.Location = new System.Drawing.Point(158, 165);
            this.TxtPreguntaCuest.Name = "TxtPreguntaCuest";
            this.TxtPreguntaCuest.Size = new System.Drawing.Size(119, 20);
            this.TxtPreguntaCuest.TabIndex = 15;
            // 
            // TxtPuntuacionCuest
            // 
            this.TxtPuntuacionCuest.Location = new System.Drawing.Point(158, 205);
            this.TxtPuntuacionCuest.Name = "TxtPuntuacionCuest";
            this.TxtPuntuacionCuest.Size = new System.Drawing.Size(119, 20);
            this.TxtPuntuacionCuest.TabIndex = 14;
            // 
            // TxtNombreCuest
            // 
            this.TxtNombreCuest.Location = new System.Drawing.Point(158, 122);
            this.TxtNombreCuest.Name = "TxtNombreCuest";
            this.TxtNombreCuest.Size = new System.Drawing.Size(119, 20);
            this.TxtNombreCuest.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Crear Cuestionario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Puntuacion Maxima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Preguntas del Cuestionario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Cuestionario:";
            // 
            // TxtDescCuest
            // 
            this.TxtDescCuest.Location = new System.Drawing.Point(158, 276);
            this.TxtDescCuest.Multiline = true;
            this.TxtDescCuest.Name = "TxtDescCuest";
            this.TxtDescCuest.Size = new System.Drawing.Size(119, 49);
            this.TxtDescCuest.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descripcion del Cuestionario:";
            // 
            // AgregarCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 403);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDescCuest);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.TxtPreguntaCuest);
            this.Controls.Add(this.TxtPuntuacionCuest);
            this.Controls.Add(this.TxtNombreCuest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgregarCuestionario";
            this.Text = "Crear Cuestionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.TextBox TxtPreguntaCuest;
        private System.Windows.Forms.TextBox TxtPuntuacionCuest;
        private System.Windows.Forms.TextBox TxtNombreCuest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescCuest;
        private System.Windows.Forms.Label label5;
    }
}