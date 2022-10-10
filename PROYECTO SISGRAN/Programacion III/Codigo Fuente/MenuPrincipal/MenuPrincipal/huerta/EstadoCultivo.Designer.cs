namespace MenuPrincipal
{
    partial class EstadoCultivo
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
            this.txtestado = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "estado de los cultivos";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(15, 25);
            this.txtestado.Multiline = true;
            this.txtestado.Name = "txtestado";
            this.txtestado.ReadOnly = true;
            this.txtestado.Size = new System.Drawing.Size(100, 194);
            this.txtestado.TabIndex = 1;
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(15, 225);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 23);
            this.btnvolver.TabIndex = 2;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // EstadoCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 250);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label1);
            this.Name = "EstadoCultivo";
            this.Text = "EstadoCultivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button btnvolver;
    }
}