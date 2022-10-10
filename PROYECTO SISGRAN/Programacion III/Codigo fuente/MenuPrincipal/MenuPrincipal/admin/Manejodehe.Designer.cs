namespace MenuPrincipal
{
    partial class Manejodehe
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
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txthuerta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproduccion = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(133, 61);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(89, 22);
            this.btnaceptar.TabIndex = 0;
            this.btnaceptar.Text = "aceptar datos";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID huerta";
            // 
            // txthuerta
            // 
            this.txthuerta.Location = new System.Drawing.Point(70, 6);
            this.txthuerta.Name = "txthuerta";
            this.txthuerta.Size = new System.Drawing.Size(152, 20);
            this.txthuerta.TabIndex = 2;
            this.txthuerta.TextChanged += new System.EventHandler(this.txthuerta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "producción por cultivo (ton.)";
            // 
            // txtproduccion
            // 
            this.txtproduccion.Location = new System.Drawing.Point(157, 35);
            this.txtproduccion.Name = "txtproduccion";
            this.txtproduccion.Size = new System.Drawing.Size(65, 20);
            this.txtproduccion.TabIndex = 4;
            this.txtproduccion.TextChanged += new System.EventHandler(this.txtproduccion_TextChanged);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(15, 61);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(48, 22);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(69, 61);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(58, 22);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Manejodehe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 94);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.txtproduccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthuerta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaceptar);
            this.Name = "Manejodehe";
            this.Text = "Manejodehe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthuerta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproduccion;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btncancelar;
    }
}