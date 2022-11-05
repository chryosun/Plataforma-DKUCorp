using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PlataformaDKUCorp
{
    partial class DesignCuestionario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Titulo = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPregunta = new System.Windows.Forms.RichTextBox();
            this.rbOp1 = new System.Windows.Forms.RadioButton();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.rbOp2 = new System.Windows.Forms.RadioButton();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.rbOp3 = new System.Windows.Forms.RadioButton();
            this.txtOp3 = new System.Windows.Forms.TextBox();
            this.rbOp4 = new System.Windows.Forms.RadioButton();
            this.txtOp4 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Titulo.Location = new System.Drawing.Point(428, 8);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(270, 45);
            this.Titulo.TabIndex = 11;
            this.Titulo.Text = "Conferencias NIIF";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(4, 8);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(87, 42);
            this.BtnAgregar.TabIndex = 12;
            this.BtnAgregar.Text = "Agregar Ejercicio";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.txtOp4);
            this.tabPage1.Controls.Add(this.txtOp3);
            this.tabPage1.Controls.Add(this.txtOp2);
            this.tabPage1.Controls.Add(this.txtOp1);
            this.tabPage1.Controls.Add(this.txtPregunta);
            this.tabPage1.Controls.Add(this.rbOp4);
            this.tabPage1.Controls.Add(this.rbOp3);
            this.tabPage1.Controls.Add(this.rbOp2);
            this.tabPage1.Controls.Add(this.rbOp1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "[ 1 ]";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(35, 45);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(539, 157);
            this.txtPregunta.TabIndex = 10;
            this.txtPregunta.Text = "";
            // 
            // rbOp1
            // 
            this.rbOp1.AutoSize = true;
            this.rbOp1.Location = new System.Drawing.Point(35, 257);
            this.rbOp1.Name = "rbOp1";
            this.rbOp1.Size = new System.Drawing.Size(37, 17);
            this.rbOp1.TabIndex = 11;
            this.rbOp1.TabStop = true;
            this.rbOp1.Text = "1) ";
            this.rbOp1.UseVisualStyleBackColor = true;
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(35, 279);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(252, 20);
            this.txtOp1.TabIndex = 12;
            this.txtOp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOp1_KeyPress);
            // 
            // rbOp2
            // 
            this.rbOp2.AutoSize = true;
            this.rbOp2.Location = new System.Drawing.Point(35, 313);
            this.rbOp2.Name = "rbOp2";
            this.rbOp2.Size = new System.Drawing.Size(37, 17);
            this.rbOp2.TabIndex = 13;
            this.rbOp2.TabStop = true;
            this.rbOp2.Text = "2) ";
            this.rbOp2.UseVisualStyleBackColor = true;
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(36, 335);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(251, 20);
            this.txtOp2.TabIndex = 14;
            this.txtOp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOp2_KeyPress);
            // 
            // rbOp3
            // 
            this.rbOp3.AutoSize = true;
            this.rbOp3.Location = new System.Drawing.Point(36, 372);
            this.rbOp3.Name = "rbOp3";
            this.rbOp3.Size = new System.Drawing.Size(37, 17);
            this.rbOp3.TabIndex = 15;
            this.rbOp3.TabStop = true;
            this.rbOp3.Text = "3) ";
            this.rbOp3.UseVisualStyleBackColor = true;
            // 
            // txtOp3
            // 
            this.txtOp3.Location = new System.Drawing.Point(36, 393);
            this.txtOp3.Name = "txtOp3";
            this.txtOp3.Size = new System.Drawing.Size(251, 20);
            this.txtOp3.TabIndex = 16;
            this.txtOp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOp3_KeyPress);
            // 
            // rbOp4
            // 
            this.rbOp4.AutoSize = true;
            this.rbOp4.Location = new System.Drawing.Point(35, 432);
            this.rbOp4.Name = "rbOp4";
            this.rbOp4.Size = new System.Drawing.Size(37, 17);
            this.rbOp4.TabIndex = 17;
            this.rbOp4.TabStop = true;
            this.rbOp4.Text = "4) ";
            this.rbOp4.UseVisualStyleBackColor = true;
            // 
            // txtOp4
            // 
            this.txtOp4.Location = new System.Drawing.Point(35, 454);
            this.txtOp4.Name = "txtOp4";
            this.txtOp4.Size = new System.Drawing.Size(252, 20);
            this.txtOp4.TabIndex = 18;
            this.txtOp4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOp4_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(825, 437);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 37);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1084, 532);
            this.tabControl.TabIndex = 10;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            this.tabControl.Enter += new System.EventHandler(this.tabPlus_Enter);
            // 
            // DesignCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 590);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DesignCuestionario";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Titulo;
        private Button BtnAgregar;
        private TabPage tabPage1;
        private Button btnGuardar;
        private TextBox txtOp4;
        private TextBox txtOp3;
        private TextBox txtOp2;
        private TextBox txtOp1;
        private RichTextBox txtPregunta;
        private RadioButton rbOp4;
        private RadioButton rbOp3;
        private RadioButton rbOp2;
        private RadioButton rbOp1;
        public TabControl tabControl;
    }
}