namespace MenuPrincipal
{
    partial class HuertaEcologica
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
            this.btnestado = new System.Windows.Forms.Button();
            this.btncarga = new System.Windows.Forms.Button();
            this.btnproduccion = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnestado
            // 
            this.btnestado.Location = new System.Drawing.Point(12, 12);
            this.btnestado.Name = "btnestado";
            this.btnestado.Size = new System.Drawing.Size(120, 23);
            this.btnestado.TabIndex = 0;
            this.btnestado.Text = "estado de cultivos";
            this.btnestado.UseVisualStyleBackColor = true;
            this.btnestado.Click += new System.EventHandler(this.btnestado_Click);
            // 
            // btncarga
            // 
            this.btncarga.Location = new System.Drawing.Point(12, 41);
            this.btncarga.Name = "btncarga";
            this.btncarga.Size = new System.Drawing.Size(120, 23);
            this.btncarga.TabIndex = 1;
            this.btncarga.Text = "carga y asociaciones";
            this.btncarga.UseVisualStyleBackColor = true;
            this.btncarga.Click += new System.EventHandler(this.btncarga_Click);
            // 
            // btnproduccion
            // 
            this.btnproduccion.Location = new System.Drawing.Point(12, 70);
            this.btnproduccion.Name = "btnproduccion";
            this.btnproduccion.Size = new System.Drawing.Size(120, 23);
            this.btnproduccion.TabIndex = 2;
            this.btnproduccion.Text = "producción por cultivo";
            this.btnproduccion.UseVisualStyleBackColor = true;
            this.btnproduccion.Click += new System.EventHandler(this.btnproduccion_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(12, 99);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(120, 23);
            this.btnvolver.TabIndex = 3;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // HuertaEcologica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(141, 134);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnproduccion);
            this.Controls.Add(this.btncarga);
            this.Controls.Add(this.btnestado);
            this.Name = "HuertaEcologica";
            this.Text = "HuertaEcologica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnestado;
        private System.Windows.Forms.Button btncarga;
        private System.Windows.Forms.Button btnproduccion;
        private System.Windows.Forms.Button btnvolver;
    }
}