namespace MenuPrincipal
{
    partial class CargasyAsociaciones
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
            this.txtasosiaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcargas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtasosiaciones
            // 
            this.txtasosiaciones.Location = new System.Drawing.Point(15, 31);
            this.txtasosiaciones.Multiline = true;
            this.txtasosiaciones.Name = "txtasosiaciones";
            this.txtasosiaciones.ReadOnly = true;
            this.txtasosiaciones.Size = new System.Drawing.Size(100, 257);
            this.txtasosiaciones.TabIndex = 0;
            this.txtasosiaciones.TextChanged += new System.EventHandler(this.txtasosiaciones_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "asosiaciones";
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(15, 294);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(216, 23);
            this.btnvolver.TabIndex = 2;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "cargas";
            // 
            // txtcargas
            // 
            this.txtcargas.Location = new System.Drawing.Point(131, 31);
            this.txtcargas.Multiline = true;
            this.txtcargas.Name = "txtcargas";
            this.txtcargas.ReadOnly = true;
            this.txtcargas.Size = new System.Drawing.Size(100, 257);
            this.txtcargas.TabIndex = 4;
            this.txtcargas.TextChanged += new System.EventHandler(this.txtcargas_TextChanged);
            // 
            // CargasyAsociaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 323);
            this.Controls.Add(this.txtcargas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtasosiaciones);
            this.Name = "CargasyAsociaciones";
            this.Text = "CargasyAsociaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtasosiaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcargas;
    }
}