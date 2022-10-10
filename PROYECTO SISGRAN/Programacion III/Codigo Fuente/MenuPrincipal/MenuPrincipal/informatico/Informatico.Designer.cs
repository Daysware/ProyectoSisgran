namespace MenuPrincipal
{
    partial class Informatico
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
            this.btndirectivo = new System.Windows.Forms.Button();
            this.btnadministracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndirectivo
            // 
            this.btndirectivo.Location = new System.Drawing.Point(12, 12);
            this.btndirectivo.Name = "btndirectivo";
            this.btndirectivo.Size = new System.Drawing.Size(127, 23);
            this.btndirectivo.TabIndex = 0;
            this.btndirectivo.Text = "ABM cuerpo directivo";
            this.btndirectivo.UseVisualStyleBackColor = true;
            this.btndirectivo.Click += new System.EventHandler(this.btndirectivo_Click);
            // 
            // btnadministracion
            // 
            this.btnadministracion.Location = new System.Drawing.Point(12, 41);
            this.btnadministracion.Name = "btnadministracion";
            this.btnadministracion.Size = new System.Drawing.Size(127, 23);
            this.btnadministracion.TabIndex = 1;
            this.btnadministracion.Text = "ABM administración";
            this.btnadministracion.UseVisualStyleBackColor = true;
            this.btnadministracion.Click += new System.EventHandler(this.btnadministracion_Click);
            // 
            // Informatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 74);
            this.Controls.Add(this.btnadministracion);
            this.Controls.Add(this.btndirectivo);
            this.Name = "Informatico";
            this.Text = "Informatico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndirectivo;
        private System.Windows.Forms.Button btnadministracion;
    }
}