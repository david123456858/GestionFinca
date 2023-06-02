namespace Presentacion
{
    partial class Registro_Pedidos
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
            this.btn_modificarP = new System.Windows.Forms.Button();
            this.btn_agregarP = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_Idpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ccempleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nombreE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_apellidoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_nombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modificarP
            // 
            this.btn_modificarP.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_modificarP.Location = new System.Drawing.Point(434, 342);
            this.btn_modificarP.Name = "btn_modificarP";
            this.btn_modificarP.Size = new System.Drawing.Size(120, 38);
            this.btn_modificarP.TabIndex = 21;
            this.btn_modificarP.Text = "Modificar";
            this.btn_modificarP.UseVisualStyleBackColor = true;
            // 
            // btn_agregarP
            // 
            this.btn_agregarP.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_agregarP.Location = new System.Drawing.Point(291, 342);
            this.btn_agregarP.Name = "btn_agregarP";
            this.btn_agregarP.Size = new System.Drawing.Size(120, 38);
            this.btn_agregarP.TabIndex = 20;
            this.btn_agregarP.Text = "Registrar";
            this.btn_agregarP.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label26.Location = new System.Drawing.Point(598, 63);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 21);
            this.label26.TabIndex = 19;
            this.label26.Text = "Cantidad";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label25.Location = new System.Drawing.Point(465, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 21);
            this.label25.TabIndex = 18;
            this.label25.Text = "Precio";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label24.Location = new System.Drawing.Point(287, 63);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 21);
            this.label24.TabIndex = 17;
            this.label24.Text = "Nombre Pedido";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label23.Location = new System.Drawing.Point(147, 63);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 21);
            this.label23.TabIndex = 16;
            this.label23.Text = "Cc Empleado";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(578, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(434, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Idpedido,
            this.C_ccempleado,
            this.C_nombreE,
            this.C_apellidoE,
            this.C_nombreP,
            this.C_precio,
            this.C_cantidad,
            this.C_fecha});
            this.dataGridView1.Location = new System.Drawing.Point(4, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // C_Idpedido
            // 
            this.C_Idpedido.HeaderText = "Id Pedido";
            this.C_Idpedido.Name = "C_Idpedido";
            this.C_Idpedido.Width = 80;
            // 
            // C_ccempleado
            // 
            this.C_ccempleado.HeaderText = "Cc Empleado";
            this.C_ccempleado.Name = "C_ccempleado";
            this.C_ccempleado.Width = 110;
            // 
            // C_nombreE
            // 
            this.C_nombreE.HeaderText = "Nombre";
            this.C_nombreE.Name = "C_nombreE";
            this.C_nombreE.Width = 80;
            // 
            // C_apellidoE
            // 
            this.C_apellidoE.HeaderText = "Apellido";
            this.C_apellidoE.Name = "C_apellidoE";
            this.C_apellidoE.Width = 80;
            // 
            // C_nombreP
            // 
            this.C_nombreP.HeaderText = "Nombre Pedido";
            this.C_nombreP.Name = "C_nombreP";
            this.C_nombreP.Width = 120;
            // 
            // C_precio
            // 
            this.C_precio.HeaderText = "Precio";
            this.C_precio.Name = "C_precio";
            this.C_precio.Width = 80;
            // 
            // C_cantidad
            // 
            this.C_cantidad.HeaderText = "Cantidad";
            this.C_cantidad.Name = "C_cantidad";
            this.C_cantidad.Width = 80;
            // 
            // C_fecha
            // 
            this.C_fecha.HeaderText = "Fecha pedido";
            this.C_fecha.Name = "C_fecha";
            this.C_fecha.Width = 120;
            // 
            // Registro_Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_modificarP);
            this.Controls.Add(this.btn_agregarP);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Registro_Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificarP;
        private System.Windows.Forms.Button btn_agregarP;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Idpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ccempleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nombreE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_apellidoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_nombreP;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_fecha;
    }
}