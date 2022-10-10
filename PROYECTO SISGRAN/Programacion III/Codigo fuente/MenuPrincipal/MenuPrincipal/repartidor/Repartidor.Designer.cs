namespace MenuPrincipal
{
    partial class Repartidor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtpedidos = new System.Windows.Forms.TextBox();
            this.txtseleccionar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelpedido = new System.Windows.Forms.Label();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(15, 187);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 0;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "pedidos a entregar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpedidos
            // 
            this.txtpedidos.Location = new System.Drawing.Point(15, 25);
            this.txtpedidos.Multiline = true;
            this.txtpedidos.Name = "txtpedidos";
            this.txtpedidos.ReadOnly = true;
            this.txtpedidos.Size = new System.Drawing.Size(162, 156);
            this.txtpedidos.TabIndex = 2;
            this.txtpedidos.TextChanged += new System.EventHandler(this.txtpedidos_TextChanged);
            // 
            // txtseleccionar
            // 
            this.txtseleccionar.Location = new System.Drawing.Point(183, 25);
            this.txtseleccionar.Name = "txtseleccionar";
            this.txtseleccionar.Size = new System.Drawing.Size(131, 20);
            this.txtseleccionar.TabIndex = 3;
            this.txtseleccionar.TextChanged += new System.EventHandler(this.txtseleccionar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "pedido seleccionado";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(183, 51);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(131, 23);
            this.btnmodificar.TabIndex = 5;
            this.btnmodificar.Text = "modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // labelnombre
            // 
            this.labelnombre.AutoSize = true;
            this.labelnombre.Location = new System.Drawing.Point(180, 88);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(93, 13);
            this.labelnombre.TabIndex = 6;
            this.labelnombre.Text = "nombre del cliente";
            this.labelnombre.Visible = false;
            this.labelnombre.Click += new System.EventHandler(this.labelnombre_Click);
            // 
            // labelpedido
            // 
            this.labelpedido.AutoSize = true;
            this.labelpedido.Location = new System.Drawing.Point(180, 145);
            this.labelpedido.Name = "labelpedido";
            this.labelpedido.Size = new System.Drawing.Size(91, 13);
            this.labelpedido.TabIndex = 7;
            this.labelpedido.Text = "estado del pedido";
            this.labelpedido.Visible = false;
            this.labelpedido.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(183, 104);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(131, 20);
            this.txtnombrecliente.TabIndex = 8;
            this.txtnombrecliente.Visible = false;
            this.txtnombrecliente.TextChanged += new System.EventHandler(this.txtnombrecliente_TextChanged);
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(183, 161);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(131, 20);
            this.txtestado.TabIndex = 9;
            this.txtestado.Visible = false;
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(183, 187);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(131, 23);
            this.btnaceptar.TabIndex = 10;
            this.btnaceptar.Text = "aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Visible = false;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(102, 187);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Repartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 217);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.labelpedido);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtseleccionar);
            this.Controls.Add(this.txtpedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnvolver);
            this.Name = "Repartidor";
            this.Text = "Repartidor";
            this.Load += new System.EventHandler(this.Repartidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpedidos;
        private System.Windows.Forms.TextBox txtseleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelpedido;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}