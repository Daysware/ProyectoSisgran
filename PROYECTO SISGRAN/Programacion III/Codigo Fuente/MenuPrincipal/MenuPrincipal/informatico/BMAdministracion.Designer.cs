namespace MenuPrincipal
{
    partial class BMAdministracion
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
            this.txtnombreadmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbaja = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtloginadmin = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombreadmin
            // 
            this.txtnombreadmin.Location = new System.Drawing.Point(126, 16);
            this.txtnombreadmin.Name = "txtnombreadmin";
            this.txtnombreadmin.Size = new System.Drawing.Size(100, 20);
            this.txtnombreadmin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nombre del empleado";
            // 
            // btnbaja
            // 
            this.btnbaja.Location = new System.Drawing.Point(12, 87);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(95, 23);
            this.btnbaja.TabIndex = 2;
            this.btnbaja.Text = "dar de baja";
            this.btnbaja.UseVisualStyleBackColor = true;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(126, 116);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 23);
            this.btnvolver.TabIndex = 3;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "login del empleado";
            // 
            // txtloginadmin
            // 
            this.txtloginadmin.Location = new System.Drawing.Point(126, 51);
            this.txtloginadmin.Name = "txtloginadmin";
            this.txtloginadmin.Size = new System.Drawing.Size(100, 20);
            this.txtloginadmin.TabIndex = 4;
            this.txtloginadmin.TextChanged += new System.EventHandler(this.txtloginadmin_TextChanged);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(12, 116);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(95, 23);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "aceptar cambios";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // BMAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 152);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtloginadmin);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombreadmin);
            this.Name = "BMAdministracion";
            this.Text = "BMAdministracion";
            this.Load += new System.EventHandler(this.BMAdministracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombreadmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloginadmin;
        private System.Windows.Forms.Button btnaceptar;
    }
}