namespace MenuPrincipal
{
    partial class ProduccionHuerta
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
            this.btnvolver = new System.Windows.Forms.Button();
            this.txtproduccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(12, 283);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(210, 22);
            this.btnvolver.TabIndex = 12;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // txtproduccion
            // 
            this.txtproduccion.Location = new System.Drawing.Point(12, 25);
            this.txtproduccion.Multiline = true;
            this.txtproduccion.Name = "txtproduccion";
            this.txtproduccion.ReadOnly = true;
            this.txtproduccion.Size = new System.Drawing.Size(210, 252);
            this.txtproduccion.TabIndex = 9;
            this.txtproduccion.TextChanged += new System.EventHandler(this.txtproduccion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "producción por huerta";
            // 
            // ProduccionHuerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.txtproduccion);
            this.Name = "ProduccionHuerta";
            this.Text = "ProduccionHuerta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.TextBox txtproduccion;
        private System.Windows.Forms.Label label1;
    }
}