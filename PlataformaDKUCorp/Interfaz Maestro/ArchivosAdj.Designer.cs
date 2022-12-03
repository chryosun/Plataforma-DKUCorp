namespace PlataformaDKUCorp.Interfaz_Maestro
{
    partial class ArchivosAdj
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
            this.btnNuevoDoc = new System.Windows.Forms.Button();
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Archivos Adjuntos de la Clase:";
            // 
            // btnNuevoDoc
            // 
            this.btnNuevoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDoc.Image = global::PlataformaDKUCorp.Properties.Resources.arrow_forward_ios_FILL0_wght400_GRAD0_opsz48;
            this.btnNuevoDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoDoc.Location = new System.Drawing.Point(189, 300);
            this.btnNuevoDoc.Name = "btnNuevoDoc";
            this.btnNuevoDoc.Size = new System.Drawing.Size(181, 37);
            this.btnNuevoDoc.TabIndex = 2;
            this.btnNuevoDoc.Text = "Añadir Archivo";
            this.btnNuevoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoDoc.UseVisualStyleBackColor = true;
            this.btnNuevoDoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstBox1
            // 
            this.lstBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.ItemHeight = 24;
            this.lstBox1.Location = new System.Drawing.Point(78, 60);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.Size = new System.Drawing.Size(404, 220);
            this.lstBox1.TabIndex = 0;
            this.lstBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ArchivosAdj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(563, 349);
            this.Controls.Add(this.lstBox1);
            this.Controls.Add(this.btnNuevoDoc);
            this.Controls.Add(this.label1);
            this.Name = "ArchivosAdj";
            this.Text = "ArchivosAdj";
            this.Load += new System.EventHandler(this.ArchivosAdj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoDoc;
        private System.Windows.Forms.ListBox lstBox1;
    }
}