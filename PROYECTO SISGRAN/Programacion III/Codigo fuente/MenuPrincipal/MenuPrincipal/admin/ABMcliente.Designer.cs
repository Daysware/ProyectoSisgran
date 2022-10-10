namespace MenuPrincipal
{
    partial class ABMcliente
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
            this.txtmodnombreempresa = new System.Windows.Forms.TextBox();
            this.txtmodterminal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radiomodnoautorizado = new System.Windows.Forms.RadioButton();
            this.radiomodautorizado = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmodcelular = new System.Windows.Forms.TextBox();
            this.txtmodemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radiomodempresa = new System.Windows.Forms.RadioButton();
            this.radiomodterminal = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtesquina = new System.Windows.Forms.TextBox();
            this.txtbarrio = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmodnombreempresa
            // 
            this.txtmodnombreempresa.Location = new System.Drawing.Point(131, 250);
            this.txtmodnombreempresa.Name = "txtmodnombreempresa";
            this.txtmodnombreempresa.Size = new System.Drawing.Size(80, 20);
            this.txtmodnombreempresa.TabIndex = 59;
            this.txtmodnombreempresa.TextChanged += new System.EventHandler(this.txtmodnombreempresa_TextChanged);
            // 
            // txtmodterminal
            // 
            this.txtmodterminal.Location = new System.Drawing.Point(79, 222);
            this.txtmodterminal.Name = "txtmodterminal";
            this.txtmodterminal.Size = new System.Drawing.Size(132, 20);
            this.txtmodterminal.TabIndex = 58;
            this.txtmodterminal.TextChanged += new System.EventHandler(this.txtmodterminal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "nombre de la empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "n°terminal";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(155, 276);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(56, 23);
            this.btnaceptar.TabIndex = 55;
            this.btnaceptar.Text = "aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "email";
            // 
            // radiomodnoautorizado
            // 
            this.radiomodnoautorizado.AutoSize = true;
            this.radiomodnoautorizado.Location = new System.Drawing.Point(150, 45);
            this.radiomodnoautorizado.Name = "radiomodnoautorizado";
            this.radiomodnoautorizado.Size = new System.Drawing.Size(37, 17);
            this.radiomodnoautorizado.TabIndex = 51;
            this.radiomodnoautorizado.Text = "no";
            this.radiomodnoautorizado.UseVisualStyleBackColor = true;
            this.radiomodnoautorizado.CheckedChanged += new System.EventHandler(this.radiomodnoautorizado_CheckedChanged);
            // 
            // radiomodautorizado
            // 
            this.radiomodautorizado.AutoSize = true;
            this.radiomodautorizado.Location = new System.Drawing.Point(79, 45);
            this.radiomodautorizado.Name = "radiomodautorizado";
            this.radiomodautorizado.Size = new System.Drawing.Size(32, 17);
            this.radiomodautorizado.TabIndex = 50;
            this.radiomodautorizado.Text = "si";
            this.radiomodautorizado.UseVisualStyleBackColor = true;
            this.radiomodautorizado.CheckedChanged += new System.EventHandler(this.radiomodautorizado_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "autorizado";
            // 
            // txtmodcelular
            // 
            this.txtmodcelular.Location = new System.Drawing.Point(58, 12);
            this.txtmodcelular.Name = "txtmodcelular";
            this.txtmodcelular.Size = new System.Drawing.Size(153, 20);
            this.txtmodcelular.TabIndex = 45;
            this.txtmodcelular.TextChanged += new System.EventHandler(this.txtmodcelular_TextChanged);
            // 
            // txtmodemail
            // 
            this.txtmodemail.Location = new System.Drawing.Point(58, 68);
            this.txtmodemail.Name = "txtmodemail";
            this.txtmodemail.Size = new System.Drawing.Size(153, 20);
            this.txtmodemail.TabIndex = 44;
            this.txtmodemail.TextChanged += new System.EventHandler(this.txtmodemail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "tipo";
            // 
            // radiomodempresa
            // 
            this.radiomodempresa.AutoSize = true;
            this.radiomodempresa.Location = new System.Drawing.Point(12, 0);
            this.radiomodempresa.Name = "radiomodempresa";
            this.radiomodempresa.Size = new System.Drawing.Size(65, 17);
            this.radiomodempresa.TabIndex = 47;
            this.radiomodempresa.Text = "empresa";
            this.radiomodempresa.UseVisualStyleBackColor = true;
            this.radiomodempresa.CheckedChanged += new System.EventHandler(this.radiomodempresa_CheckedChanged);
            // 
            // radiomodterminal
            // 
            this.radiomodterminal.AutoSize = true;
            this.radiomodterminal.Location = new System.Drawing.Point(83, 1);
            this.radiomodterminal.Name = "radiomodterminal";
            this.radiomodterminal.Size = new System.Drawing.Size(61, 17);
            this.radiomodterminal.TabIndex = 48;
            this.radiomodterminal.Text = "terminal";
            this.radiomodterminal.UseVisualStyleBackColor = true;
            this.radiomodterminal.CheckedChanged += new System.EventHandler(this.radiomodterminal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "calle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "numero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "esquina";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "barrio";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtcalle
            // 
            this.txtcalle.Location = new System.Drawing.Point(58, 94);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(153, 20);
            this.txtcalle.TabIndex = 64;
            this.txtcalle.TextChanged += new System.EventHandler(this.txtcalle_TextChanged);
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(58, 120);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(153, 20);
            this.txtnumero.TabIndex = 65;
            this.txtnumero.TextChanged += new System.EventHandler(this.txtnumero_TextChanged);
            // 
            // txtesquina
            // 
            this.txtesquina.Location = new System.Drawing.Point(58, 146);
            this.txtesquina.Name = "txtesquina";
            this.txtesquina.Size = new System.Drawing.Size(153, 20);
            this.txtesquina.TabIndex = 66;
            this.txtesquina.TextChanged += new System.EventHandler(this.txtesquina_TextChanged);
            // 
            // txtbarrio
            // 
            this.txtbarrio.Location = new System.Drawing.Point(58, 172);
            this.txtbarrio.Name = "txtbarrio";
            this.txtbarrio.Size = new System.Drawing.Size(153, 20);
            this.txtbarrio.TabIndex = 67;
            this.txtbarrio.TextChanged += new System.EventHandler(this.txtbarrio_TextChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(79, 276);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(65, 23);
            this.btncancelar.TabIndex = 68;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(17, 276);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(50, 23);
            this.btnvolver.TabIndex = 69;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiomodterminal);
            this.groupBox1.Controls.Add(this.radiomodempresa);
            this.groupBox1.Location = new System.Drawing.Point(58, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 20);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            // 
            // ABMcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.txtbarrio);
            this.Controls.Add(this.txtesquina);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmodnombreempresa);
            this.Controls.Add(this.txtmodterminal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radiomodnoautorizado);
            this.Controls.Add(this.radiomodautorizado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmodcelular);
            this.Controls.Add(this.txtmodemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ABMcliente";
            this.Text = "ABMcliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmodnombreempresa;
        private System.Windows.Forms.TextBox txtmodterminal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radiomodnoautorizado;
        private System.Windows.Forms.RadioButton radiomodautorizado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmodcelular;
        private System.Windows.Forms.TextBox txtmodemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radiomodempresa;
        private System.Windows.Forms.RadioButton radiomodterminal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtesquina;
        private System.Windows.Forms.TextBox txtbarrio;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}