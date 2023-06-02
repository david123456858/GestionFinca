namespace Presentacion
{
    partial class Registro_Escogidos
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
            this.txtE_cedula_A3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtCC = new System.Windows.Forms.TextBox();
            this.TxtCantEsco = new System.Windows.Forms.TextBox();
            this.FechaRegisEscogidos = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridRegisEsc = new System.Windows.Forms.DataGridView();
            this.ColumNescogido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFechaeSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegisEsCo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegisEsc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtE_cedula_A3
            // 
            this.txtE_cedula_A3.Location = new System.Drawing.Point(51, 90);
            this.txtE_cedula_A3.Name = "txtE_cedula_A3";
            this.txtE_cedula_A3.Size = new System.Drawing.Size(154, 20);
            this.txtE_cedula_A3.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(47, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cc del Jefe a cargo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label19.Location = new System.Drawing.Point(244, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(117, 21);
            this.label19.TabIndex = 23;
            this.label19.Text = "Cc Empleado";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(80, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 22;
            // 
            // TxtCC
            // 
            this.TxtCC.Location = new System.Drawing.Point(221, 90);
            this.TxtCC.Name = "TxtCC";
            this.TxtCC.Size = new System.Drawing.Size(158, 20);
            this.TxtCC.TabIndex = 17;
            // 
            // TxtCantEsco
            // 
            this.TxtCantEsco.Location = new System.Drawing.Point(406, 90);
            this.TxtCantEsco.Name = "TxtCantEsco";
            this.TxtCantEsco.Size = new System.Drawing.Size(158, 20);
            this.TxtCantEsco.TabIndex = 19;
            // 
            // FechaRegisEscogidos
            // 
            this.FechaRegisEscogidos.Location = new System.Drawing.Point(588, 90);
            this.FechaRegisEscogidos.Name = "FechaRegisEscogidos";
            this.FechaRegisEscogidos.Size = new System.Drawing.Size(158, 20);
            this.FechaRegisEscogidos.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.Location = new System.Drawing.Point(402, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cantidad Escogida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(634, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fecha";
            // 
            // dataGridRegisEsc
            // 
            this.dataGridRegisEsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegisEsc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNescogido,
            this.ColumCC,
            this.ColumCantidad,
            this.ColumFechaeSC});
            this.dataGridRegisEsc.Location = new System.Drawing.Point(129, 150);
            this.dataGridRegisEsc.Name = "dataGridRegisEsc";
            this.dataGridRegisEsc.RowHeadersWidth = 51;
            this.dataGridRegisEsc.Size = new System.Drawing.Size(553, 150);
            this.dataGridRegisEsc.TabIndex = 26;
            // 
            // ColumNescogido
            // 
            this.ColumNescogido.HeaderText = "N°Escogido";
            this.ColumNescogido.Name = "ColumNescogido";
            this.ColumNescogido.Width = 80;
            // 
            // ColumCC
            // 
            this.ColumCC.HeaderText = "Cc Empleado";
            this.ColumCC.MinimumWidth = 6;
            this.ColumCC.Name = "ColumCC";
            this.ColumCC.ReadOnly = true;
            this.ColumCC.Width = 130;
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad Escogida";
            this.ColumCantidad.MinimumWidth = 6;
            this.ColumCantidad.Name = "ColumCantidad";
            this.ColumCantidad.ReadOnly = true;
            this.ColumCantidad.Width = 140;
            // 
            // ColumFechaeSC
            // 
            this.ColumFechaeSC.HeaderText = "Fecha Registro";
            this.ColumFechaeSC.MinimumWidth = 6;
            this.ColumFechaeSC.Name = "ColumFechaeSC";
            this.ColumFechaeSC.ReadOnly = true;
            this.ColumFechaeSC.Width = 150;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(406, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 28;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRegisEsCo
            // 
            this.btnRegisEsCo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegisEsCo.Location = new System.Drawing.Point(269, 334);
            this.btnRegisEsCo.Name = "btnRegisEsCo";
            this.btnRegisEsCo.Size = new System.Drawing.Size(120, 38);
            this.btnRegisEsCo.TabIndex = 27;
            this.btnRegisEsCo.Text = "Registrar";
            this.btnRegisEsCo.UseVisualStyleBackColor = true;
            this.btnRegisEsCo.Click += new System.EventHandler(this.btnRegisEsCo_Click);
            // 
            // Registro_Escogidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegisEsCo);
            this.Controls.Add(this.dataGridRegisEsc);
            this.Controls.Add(this.txtE_cedula_A3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtCC);
            this.Controls.Add(this.TxtCantEsco);
            this.Controls.Add(this.FechaRegisEscogidos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Name = "Registro_Escogidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Escogidos";
            this.Load += new System.EventHandler(this.Registro_Escogidos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_Escogidos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegisEsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtE_cedula_A3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtCC;
        private System.Windows.Forms.TextBox TxtCantEsco;
        private System.Windows.Forms.DateTimePicker FechaRegisEscogidos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridRegisEsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNescogido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFechaeSC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegisEsCo;
    }
}