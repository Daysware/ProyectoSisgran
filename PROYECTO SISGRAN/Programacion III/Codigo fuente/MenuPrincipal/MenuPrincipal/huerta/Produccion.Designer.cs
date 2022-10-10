namespace MenuPrincipal
{
    partial class Produccion
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
            this.txtcultivo = new System.Windows.Forms.TextBox();
            this.txtproduccion = new System.Windows.Forms.TextBox();
            this.txtvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "cultivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "produccion";
            // 
            // txtcultivo
            // 
            this.txtcultivo.Location = new System.Drawing.Point(12, 25);
            this.txtcultivo.Multiline = true;
            this.txtcultivo.Name = "txtcultivo";
            this.txtcultivo.ReadOnly = true;
            this.txtcultivo.Size = new System.Drawing.Size(85, 242);
            this.txtcultivo.TabIndex = 2;
            this.txtcultivo.TextChanged += new System.EventHandler(this.txtcultivo_TextChanged);
            // 
            // txtproduccion
            // 
            this.txtproduccion.Location = new System.Drawing.Point(97, 25);
            this.txtproduccion.Multiline = true;
            this.txtproduccion.Name = "txtproduccion";
            this.txtproduccion.ReadOnly = true;
            this.txtproduccion.Size = new System.Drawing.Size(85, 242);
            this.txtproduccion.TabIndex = 3;
            this.txtproduccion.TextChanged += new System.EventHandler(this.txtproduccion_TextChanged);
            // 
            // txtvolver
            // 
            this.txtvolver.Location = new System.Drawing.Point(12, 273);
            this.txtvolver.Name = "txtvolver";
            this.txtvolver.Size = new System.Drawing.Size(170, 23);
            this.txtvolver.TabIndex = 4;
            this.txtvolver.Text = "volver";
            this.txtvolver.UseVisualStyleBackColor = true;
            this.txtvolver.Click += new System.EventHandler(this.txtvolver_Click);
            // 
            // Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 307);
            this.Controls.Add(this.txtvolver);
            this.Controls.Add(this.txtproduccion);
            this.Controls.Add(this.txtcultivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Produccion";
            this.Text = "Produccion";
            this.Load += new System.EventHandler(this.Produccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcultivo;
        private System.Windows.Forms.TextBox txtproduccion;
        private System.Windows.Forms.Button txtvolver;
    }
}