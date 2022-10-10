namespace MenuPrincipal
{
    partial class ABMAdministracion
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
            this.btneditar = new System.Windows.Forms.Button();
            this.txtmiembro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcuerpodirectivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(95, 270);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(64, 23);
            this.btnvolver.TabIndex = 11;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(15, 270);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(64, 23);
            this.btneditar.TabIndex = 10;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtmiembro
            // 
            this.txtmiembro.Location = new System.Drawing.Point(15, 244);
            this.txtmiembro.Name = "txtmiembro";
            this.txtmiembro.Size = new System.Drawing.Size(144, 20);
            this.txtmiembro.TabIndex = 9;
            this.txtmiembro.TextChanged += new System.EventHandler(this.txtmiembro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "empleado seleccionado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtcuerpodirectivo
            // 
            this.txtcuerpodirectivo.Location = new System.Drawing.Point(15, 25);
            this.txtcuerpodirectivo.Multiline = true;
            this.txtcuerpodirectivo.Name = "txtcuerpodirectivo";
            this.txtcuerpodirectivo.ReadOnly = true;
            this.txtcuerpodirectivo.Size = new System.Drawing.Size(144, 200);
            this.txtcuerpodirectivo.TabIndex = 7;
            this.txtcuerpodirectivo.TextChanged += new System.EventHandler(this.txtcuerpodirectivo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "personal de administración";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ABMAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 303);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtmiembro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcuerpodirectivo);
            this.Controls.Add(this.label1);
            this.Name = "ABMAdministracion";
            this.Text = "ABMAdministracion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.TextBox txtmiembro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcuerpodirectivo;
        private System.Windows.Forms.Label label1;
    }
}