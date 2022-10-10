namespace MenuPrincipal
{
    partial class infocliente
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
            this.txtnombreempresa = new System.Windows.Forms.TextBox();
            this.txtterminal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radionoautorizado = new System.Windows.Forms.RadioButton();
            this.radioautorizado = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioterminal = new System.Windows.Forms.RadioButton();
            this.radioempresa = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombreempresa
            // 
            this.txtnombreempresa.Location = new System.Drawing.Point(124, 192);
            this.txtnombreempresa.Name = "txtnombreempresa";
            this.txtnombreempresa.ReadOnly = true;
            this.txtnombreempresa.Size = new System.Drawing.Size(80, 20);
            this.txtnombreempresa.TabIndex = 39;
            this.txtnombreempresa.TextChanged += new System.EventHandler(this.txtnombreempresa_TextChanged);
            // 
            // txtterminal
            // 
            this.txtterminal.Location = new System.Drawing.Point(72, 164);
            this.txtterminal.Name = "txtterminal";
            this.txtterminal.ReadOnly = true;
            this.txtterminal.Size = new System.Drawing.Size(132, 20);
            this.txtterminal.TabIndex = 38;
            this.txtterminal.TextChanged += new System.EventHandler(this.txtterminal_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "nombre de la empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "n°terminal";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(129, 218);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 35;
            this.btnmodificar.Text = "modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(69, 114);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.ReadOnly = true;
            this.txtdireccion.Size = new System.Drawing.Size(132, 20);
            this.txtdireccion.TabIndex = 34;
            this.txtdireccion.TextChanged += new System.EventHandler(this.txtdireccion_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "email";
            // 
            // radionoautorizado
            // 
            this.radionoautorizado.AutoCheck = false;
            this.radionoautorizado.AutoSize = true;
            this.radionoautorizado.Location = new System.Drawing.Point(143, 58);
            this.radionoautorizado.Name = "radionoautorizado";
            this.radionoautorizado.Size = new System.Drawing.Size(37, 17);
            this.radionoautorizado.TabIndex = 31;
            this.radionoautorizado.TabStop = true;
            this.radionoautorizado.Text = "no";
            this.radionoautorizado.UseVisualStyleBackColor = true;
            this.radionoautorizado.CheckedChanged += new System.EventHandler(this.radionoautorizado_CheckedChanged);
            // 
            // radioautorizado
            // 
            this.radioautorizado.AutoCheck = false;
            this.radioautorizado.AutoSize = true;
            this.radioautorizado.Location = new System.Drawing.Point(72, 58);
            this.radioautorizado.Name = "radioautorizado";
            this.radioautorizado.Size = new System.Drawing.Size(32, 17);
            this.radioautorizado.TabIndex = 30;
            this.radioautorizado.TabStop = true;
            this.radioautorizado.Text = "si";
            this.radioautorizado.UseVisualStyleBackColor = true;
            this.radioautorizado.CheckedChanged += new System.EventHandler(this.radioautorizado_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "autorizado";
            // 
            // radioterminal
            // 
            this.radioterminal.AutoCheck = false;
            this.radioterminal.AutoSize = true;
            this.radioterminal.Location = new System.Drawing.Point(79, 6);
            this.radioterminal.Name = "radioterminal";
            this.radioterminal.Size = new System.Drawing.Size(61, 17);
            this.radioterminal.TabIndex = 28;
            this.radioterminal.TabStop = true;
            this.radioterminal.Text = "terminal";
            this.radioterminal.UseVisualStyleBackColor = true;
            this.radioterminal.CheckedChanged += new System.EventHandler(this.radioterminal_CheckedChanged);
            // 
            // radioempresa
            // 
            this.radioempresa.AutoCheck = false;
            this.radioempresa.AutoSize = true;
            this.radioempresa.Location = new System.Drawing.Point(8, 6);
            this.radioempresa.Name = "radioempresa";
            this.radioempresa.Size = new System.Drawing.Size(65, 17);
            this.radioempresa.TabIndex = 27;
            this.radioempresa.TabStop = true;
            this.radioempresa.Text = "empresa";
            this.radioempresa.UseVisualStyleBackColor = true;
            this.radioempresa.CheckedChanged += new System.EventHandler(this.radioempresa_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "tipo";
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(51, 25);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.ReadOnly = true;
            this.txtcelular.Size = new System.Drawing.Size(153, 20);
            this.txtcelular.TabIndex = 25;
            this.txtcelular.TextChanged += new System.EventHandler(this.txtcelular_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(51, 81);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(153, 20);
            this.txtemail.TabIndex = 24;
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID cliente";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(65, -1);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(139, 20);
            this.txtidcliente.TabIndex = 20;
            this.txtidcliente.TextChanged += new System.EventHandler(this.txtidcliente_TextChanged);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(12, 218);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 40;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioempresa);
            this.groupBox1.Controls.Add(this.radioterminal);
            this.groupBox1.Location = new System.Drawing.Point(60, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 24);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // infocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 253);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.txtnombreempresa);
            this.Controls.Add(this.txtterminal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radionoautorizado);
            this.Controls.Add(this.radioautorizado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidcliente);
            this.Name = "infocliente";
            this.Text = "infocliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombreempresa;
        private System.Windows.Forms.TextBox txtterminal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radionoautorizado;
        private System.Windows.Forms.RadioButton radioautorizado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioterminal;
        private System.Windows.Forms.RadioButton radioempresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}