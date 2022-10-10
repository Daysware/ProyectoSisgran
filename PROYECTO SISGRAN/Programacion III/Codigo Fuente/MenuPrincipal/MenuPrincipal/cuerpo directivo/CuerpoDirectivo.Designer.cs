namespace MenuPrincipal
{
    partial class CuerpoDirectivo
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
            this.btnavance = new System.Windows.Forms.Button();
            this.btnproduccion = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnavance
            // 
            this.btnavance.Location = new System.Drawing.Point(12, 12);
            this.btnavance.Name = "btnavance";
            this.btnavance.Size = new System.Drawing.Size(157, 23);
            this.btnavance.TabIndex = 0;
            this.btnavance.Text = "consultar avance de pedidos";
            this.btnavance.UseVisualStyleBackColor = true;
            this.btnavance.Click += new System.EventHandler(this.btnavance_Click);
            // 
            // btnproduccion
            // 
            this.btnproduccion.Location = new System.Drawing.Point(12, 41);
            this.btnproduccion.Name = "btnproduccion";
            this.btnproduccion.Size = new System.Drawing.Size(157, 23);
            this.btnproduccion.TabIndex = 1;
            this.btnproduccion.Text = "produccion por huerta";
            this.btnproduccion.UseVisualStyleBackColor = true;
            this.btnproduccion.Click += new System.EventHandler(this.btnproduccion_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(12, 70);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(157, 23);
            this.btnvolver.TabIndex = 2;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // CuerpoDirectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 101);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnproduccion);
            this.Controls.Add(this.btnavance);
            this.Name = "CuerpoDirectivo";
            this.Text = "CuerpoDirectivo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnavance;
        private System.Windows.Forms.Button btnproduccion;
        private System.Windows.Forms.Button btnvolver;
    }
}