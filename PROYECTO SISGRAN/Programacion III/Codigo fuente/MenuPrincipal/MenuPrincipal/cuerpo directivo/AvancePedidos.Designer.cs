namespace MenuPrincipal
{
    partial class AvancePedidos
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
            this.txtestadopedidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtestadopedidos
            // 
            this.txtestadopedidos.Location = new System.Drawing.Point(15, 25);
            this.txtestadopedidos.Multiline = true;
            this.txtestadopedidos.Name = "txtestadopedidos";
            this.txtestadopedidos.ReadOnly = true;
            this.txtestadopedidos.Size = new System.Drawing.Size(174, 269);
            this.txtestadopedidos.TabIndex = 0;
            this.txtestadopedidos.TextChanged += new System.EventHandler(this.txtestadopedidos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "estado de pedidos";
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(15, 300);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(174, 23);
            this.btnvolver.TabIndex = 2;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // AvancePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 329);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtestadopedidos);
            this.Name = "AvancePedidos";
            this.Text = "AvancePedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtestadopedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolver;
    }
}