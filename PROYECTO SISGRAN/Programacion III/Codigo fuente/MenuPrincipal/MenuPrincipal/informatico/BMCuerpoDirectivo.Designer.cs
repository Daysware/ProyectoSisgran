namespace MenuPrincipal
{
    partial class BMCuerpoDirectivo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtloginmiembro = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnbaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombremiembro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtañomiembro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(14, 106);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(95, 23);
            this.btnaceptar.TabIndex = 13;
            this.btnaceptar.Text = "aceptar cambios";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "login del miembro";
            // 
            // txtloginmiembro
            // 
            this.txtloginmiembro.Location = new System.Drawing.Point(126, 32);
            this.txtloginmiembro.Name = "txtloginmiembro";
            this.txtloginmiembro.Size = new System.Drawing.Size(100, 20);
            this.txtloginmiembro.TabIndex = 11;
            this.txtloginmiembro.TextChanged += new System.EventHandler(this.txtloginmiembro_TextChanged);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(128, 106);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(100, 23);
            this.btnvolver.TabIndex = 10;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btnbaja
            // 
            this.btnbaja.Location = new System.Drawing.Point(14, 77);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(95, 23);
            this.btnbaja.TabIndex = 9;
            this.btnbaja.Text = "dar de baja";
            this.btnbaja.UseVisualStyleBackColor = true;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "nombre del miembro";
            // 
            // txtnombremiembro
            // 
            this.txtnombremiembro.Location = new System.Drawing.Point(126, 6);
            this.txtnombremiembro.Name = "txtnombremiembro";
            this.txtnombremiembro.Size = new System.Drawing.Size(100, 20);
            this.txtnombremiembro.TabIndex = 7;
            this.txtnombremiembro.TextChanged += new System.EventHandler(this.txtnombremiembro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "año de ingreso";
            // 
            // txtañomiembro
            // 
            this.txtañomiembro.Location = new System.Drawing.Point(125, 58);
            this.txtañomiembro.Name = "txtañomiembro";
            this.txtañomiembro.Size = new System.Drawing.Size(100, 20);
            this.txtañomiembro.TabIndex = 14;
            this.txtañomiembro.TextChanged += new System.EventHandler(this.txtañomiembro_TextChanged);
            // 
            // BMCuerpoDirectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 140);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtañomiembro);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtloginmiembro);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombremiembro);
            this.Name = "BMCuerpoDirectivo";
            this.Text = "BMCuerpoDirectivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloginmiembro;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombremiembro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtañomiembro;
    }
}