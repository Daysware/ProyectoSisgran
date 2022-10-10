namespace MenuPrincipal
{
    partial class ABMCuerpoDirectivo
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
            this.txtcuerpodirectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmiembro = new System.Windows.Forms.TextBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "miembros del cuerpo directivo";
            // 
            // txtcuerpodirectivo
            // 
            this.txtcuerpodirectivo.Location = new System.Drawing.Point(15, 25);
            this.txtcuerpodirectivo.Multiline = true;
            this.txtcuerpodirectivo.Name = "txtcuerpodirectivo";
            this.txtcuerpodirectivo.ReadOnly = true;
            this.txtcuerpodirectivo.Size = new System.Drawing.Size(144, 200);
            this.txtcuerpodirectivo.TabIndex = 1;
            this.txtcuerpodirectivo.TextChanged += new System.EventHandler(this.txtcuerpodirectivo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "miembro seleccionado";
            // 
            // txtmiembro
            // 
            this.txtmiembro.Location = new System.Drawing.Point(15, 244);
            this.txtmiembro.Name = "txtmiembro";
            this.txtmiembro.Size = new System.Drawing.Size(144, 20);
            this.txtmiembro.TabIndex = 3;
            this.txtmiembro.TextChanged += new System.EventHandler(this.txtmiembro_TextChanged);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(15, 270);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(64, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(95, 270);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(64, 23);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // ABMCuerpoDirectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 302);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtmiembro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcuerpodirectivo);
            this.Controls.Add(this.label1);
            this.Name = "ABMCuerpoDirectivo";
            this.Text = "ABMCuerpoDirectivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcuerpodirectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmiembro;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnvolver;
    }
}