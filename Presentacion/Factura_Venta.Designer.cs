namespace Presentacion
{
    partial class Factura_Venta
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
            this.txtRV_valor_B = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRV_nombre_E = new System.Windows.Forms.TextBox();
            this.txtE_cedula_A4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRegistrarVentas = new System.Windows.Forms.Button();
            this.dataGridVenta = new System.Windows.Forms.DataGridView();
            this.ColumRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumKilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFactor = new System.Windows.Forms.TextBox();
            this.TxtValorxK = new System.Windows.Forms.TextBox();
            this.TxtKilosL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRV_valor_B
            // 
            this.txtRV_valor_B.Location = new System.Drawing.Point(425, 89);
            this.txtRV_valor_B.Name = "txtRV_valor_B";
            this.txtRV_valor_B.Size = new System.Drawing.Size(154, 20);
            this.txtRV_valor_B.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label22.Location = new System.Drawing.Point(436, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 21);
            this.label22.TabIndex = 37;
            this.label22.Text = "Valor base";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label21.Location = new System.Drawing.Point(67, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 21);
            this.label21.TabIndex = 36;
            this.label21.Text = "Empresa";
            // 
            // txtRV_nombre_E
            // 
            this.txtRV_nombre_E.Location = new System.Drawing.Point(56, 89);
            this.txtRV_nombre_E.Name = "txtRV_nombre_E";
            this.txtRV_nombre_E.Size = new System.Drawing.Size(154, 20);
            this.txtRV_nombre_E.TabIndex = 35;
            // 
            // txtE_cedula_A4
            // 
            this.txtE_cedula_A4.Location = new System.Drawing.Point(56, 26);
            this.txtE_cedula_A4.Name = "txtE_cedula_A4";
            this.txtE_cedula_A4.Size = new System.Drawing.Size(154, 20);
            this.txtE_cedula_A4.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(28, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cc del Jefe a cargo";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, -19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 32;
            // 
            // btnRegistrarVentas
            // 
            this.btnRegistrarVentas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegistrarVentas.Location = new System.Drawing.Point(616, 48);
            this.btnRegistrarVentas.Name = "btnRegistrarVentas";
            this.btnRegistrarVentas.Size = new System.Drawing.Size(120, 38);
            this.btnRegistrarVentas.TabIndex = 29;
            this.btnRegistrarVentas.Text = "Registrar";
            this.btnRegistrarVentas.UseVisualStyleBackColor = true;
            // 
            // dataGridVenta
            // 
            this.dataGridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumRef,
            this.Column1,
            this.ColumFactor,
            this.ColumValor,
            this.ColumKilos,
            this.ColumTotal,
            this.ColumFecha});
            this.dataGridVenta.Location = new System.Drawing.Point(12, 149);
            this.dataGridVenta.Name = "dataGridVenta";
            this.dataGridVenta.RowHeadersWidth = 51;
            this.dataGridVenta.Size = new System.Drawing.Size(773, 299);
            this.dataGridVenta.TabIndex = 31;
            // 
            // ColumRef
            // 
            this.ColumRef.HeaderText = "N°Venta";
            this.ColumRef.MinimumWidth = 6;
            this.ColumRef.Name = "ColumRef";
            this.ColumRef.ReadOnly = true;
            this.ColumRef.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = " Empresa";
            this.Column1.Name = "Column1";
            // 
            // ColumFactor
            // 
            this.ColumFactor.HeaderText = "% Factor";
            this.ColumFactor.MinimumWidth = 6;
            this.ColumFactor.Name = "ColumFactor";
            this.ColumFactor.Width = 110;
            // 
            // ColumValor
            // 
            this.ColumValor.HeaderText = "Valor Kilo";
            this.ColumValor.MinimumWidth = 6;
            this.ColumValor.Name = "ColumValor";
            this.ColumValor.ReadOnly = true;
            // 
            // ColumKilos
            // 
            this.ColumKilos.HeaderText = "Kilos Totales";
            this.ColumKilos.MinimumWidth = 6;
            this.ColumKilos.Name = "ColumKilos";
            this.ColumKilos.ReadOnly = true;
            // 
            // ColumTotal
            // 
            this.ColumTotal.HeaderText = "Total Pagar";
            this.ColumTotal.MinimumWidth = 6;
            this.ColumTotal.Name = "ColumTotal";
            this.ColumTotal.ReadOnly = true;
            // 
            // ColumFecha
            // 
            this.ColumFecha.HeaderText = "Fecha Registro";
            this.ColumFecha.MinimumWidth = 6;
            this.ColumFecha.Name = "ColumFecha";
            this.ColumFecha.ReadOnly = true;
            this.ColumFecha.Width = 130;
            // 
            // TxtFactor
            // 
            this.TxtFactor.Location = new System.Drawing.Point(239, 26);
            this.TxtFactor.Name = "TxtFactor";
            this.TxtFactor.Size = new System.Drawing.Size(154, 20);
            this.TxtFactor.TabIndex = 27;
            // 
            // TxtValorxK
            // 
            this.TxtValorxK.Location = new System.Drawing.Point(425, 26);
            this.TxtValorxK.Name = "TxtValorxK";
            this.TxtValorxK.Size = new System.Drawing.Size(154, 20);
            this.TxtValorxK.TabIndex = 26;
            // 
            // TxtKilosL
            // 
            this.TxtKilosL.Location = new System.Drawing.Point(239, 89);
            this.TxtKilosL.Name = "TxtKilosL";
            this.TxtKilosL.Size = new System.Drawing.Size(154, 20);
            this.TxtKilosL.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(413, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "¿Valor por kilo?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(199, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "¿Cuantos kilos llevara?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(245, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "¿% Factor?";
            // 
            // Factura_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.txtRV_valor_B);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtRV_nombre_E);
            this.Controls.Add(this.txtE_cedula_A4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnRegistrarVentas);
            this.Controls.Add(this.dataGridVenta);
            this.Controls.Add(this.TxtFactor);
            this.Controls.Add(this.TxtValorxK);
            this.Controls.Add(this.TxtKilosL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Name = "Factura_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura_Venta";
            this.Load += new System.EventHandler(this.Factura_Venta_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Factura_Venta_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRV_valor_B;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRV_nombre_E;
        private System.Windows.Forms.TextBox txtE_cedula_A4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnRegistrarVentas;
        private System.Windows.Forms.DataGridView dataGridVenta;
        private System.Windows.Forms.TextBox TxtFactor;
        private System.Windows.Forms.TextBox TxtValorxK;
        private System.Windows.Forms.TextBox TxtKilosL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumKilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFecha;
    }
}