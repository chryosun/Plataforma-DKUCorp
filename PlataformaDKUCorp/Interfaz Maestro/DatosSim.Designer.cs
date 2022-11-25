namespace PlataformaDKUCorp.Creacion_de_Cuestionario
{
    partial class DatosSim
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.TxtPreguntaSim = new System.Windows.Forms.TextBox();
            this.TxtPuntuacionSim = new System.Windows.Forms.TextBox();
            this.TxtNombreSim = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescSim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardarConfig = new System.Windows.Forms.Button();
            this.lblSimID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(458, 550);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(121, 54);
            this.BtnAgregar.TabIndex = 17;
            this.BtnAgregar.Text = "Agregar Cuestionario";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(29, 560);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(104, 35);
            this.BtnRegresar.TabIndex = 16;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // TxtPreguntaSim
            // 
            this.TxtPreguntaSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreguntaSim.Location = new System.Drawing.Point(29, 210);
            this.TxtPreguntaSim.MaxLength = 2;
            this.TxtPreguntaSim.Name = "TxtPreguntaSim";
            this.TxtPreguntaSim.Size = new System.Drawing.Size(47, 26);
            this.TxtPreguntaSim.TabIndex = 15;
            // 
            // TxtPuntuacionSim
            // 
            this.TxtPuntuacionSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntuacionSim.Location = new System.Drawing.Point(29, 280);
            this.TxtPuntuacionSim.MaxLength = 2;
            this.TxtPuntuacionSim.Name = "TxtPuntuacionSim";
            this.TxtPuntuacionSim.Size = new System.Drawing.Size(47, 26);
            this.TxtPuntuacionSim.TabIndex = 14;
            // 
            // TxtNombreSim
            // 
            this.TxtNombreSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreSim.Location = new System.Drawing.Point(29, 139);
            this.TxtNombreSim.MaxLength = 30;
            this.TxtNombreSim.Name = "TxtNombreSim";
            this.TxtNombreSim.Size = new System.Drawing.Size(252, 26);
            this.TxtNombreSim.TabIndex = 13;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(188, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(226, 37);
            this.Titulo.TabIndex = 12;
            this.Titulo.Text = "Crear Simulación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Puntuación Maxima:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Numero de fases del Simulador:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre de Simulacion:";
            // 
            // TxtDescSim
            // 
            this.TxtDescSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescSim.Location = new System.Drawing.Point(29, 346);
            this.TxtDescSim.MaxLength = 100;
            this.TxtDescSim.Multiline = true;
            this.TxtDescSim.Name = "TxtDescSim";
            this.TxtDescSim.Size = new System.Drawing.Size(458, 163);
            this.TxtDescSim.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descripción de la Simulación:";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEditar.Location = new System.Drawing.Point(222, 560);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(161, 35);
            this.BtnEditar.TabIndex = 20;
            this.BtnEditar.Text = "Editar Cuestionario";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardarConfig
            // 
            this.BtnGuardarConfig.BackgroundImage = global::PlataformaDKUCorp.Properties.Resources.save_FILL0_wght400_GRAD0_opsz48;
            this.BtnGuardarConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnGuardarConfig.Location = new System.Drawing.Point(458, 97);
            this.BtnGuardarConfig.Name = "BtnGuardarConfig";
            this.BtnGuardarConfig.Size = new System.Drawing.Size(140, 60);
            this.BtnGuardarConfig.TabIndex = 21;
            this.BtnGuardarConfig.Text = "Guardar Cambios";
            this.BtnGuardarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardarConfig.UseVisualStyleBackColor = true;
            this.BtnGuardarConfig.Click += new System.EventHandler(this.BtnGuardarConfig_Click);
            // 
            // lblSimID
            // 
            this.lblSimID.AutoSize = true;
            this.lblSimID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimID.Location = new System.Drawing.Point(89, 59);
            this.lblSimID.Name = "lblSimID";
            this.lblSimID.Size = new System.Drawing.Size(27, 20);
            this.lblSimID.TabIndex = 22;
            this.lblSimID.Text = "__";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID:";
            // 
            // DatosSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 623);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSimID);
            this.Controls.Add(this.BtnGuardarConfig);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDescSim);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.TxtPreguntaSim);
            this.Controls.Add(this.TxtPuntuacionSim);
            this.Controls.Add(this.TxtNombreSim);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosSim";
            this.Text = "Crear Simulación";
            this.Load += new System.EventHandler(this.DatosCuestionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.TextBox TxtPreguntaSim;
        private System.Windows.Forms.TextBox TxtPuntuacionSim;
        private System.Windows.Forms.TextBox TxtNombreSim;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescSim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardarConfig;
        private System.Windows.Forms.Label lblSimID;
        private System.Windows.Forms.Label label6;
    }
}