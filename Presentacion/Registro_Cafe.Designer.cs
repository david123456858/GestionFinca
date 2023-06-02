namespace Presentacion
{
    partial class Registro_Cafe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtE_cedula_A2 = new System.Windows.Forms.TextBox();
            this.TxtKilosC = new System.Windows.Forms.TextBox();
            this.TxtKilosS = new System.Windows.Forms.TextBox();
            this.dataGridCafe = new System.Windows.Forms.DataGridView();
            this.ColumNcafe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSecos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCerezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFechacafe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnregistrar_cafe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(222, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilos de Cafe Recolectados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(92, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cc del Jefe a Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(310, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cerezas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(493, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Secos";
            // 
            // txtE_cedula_A2
            // 
            this.txtE_cedula_A2.Location = new System.Drawing.Point(96, 129);
            this.txtE_cedula_A2.Name = "txtE_cedula_A2";
            this.txtE_cedula_A2.Size = new System.Drawing.Size(154, 20);
            this.txtE_cedula_A2.TabIndex = 4;
            // 
            // TxtKilosC
            // 
            this.TxtKilosC.Location = new System.Drawing.Point(269, 129);
            this.TxtKilosC.Name = "TxtKilosC";
            this.TxtKilosC.Size = new System.Drawing.Size(154, 20);
            this.TxtKilosC.TabIndex = 5;
            // 
            // TxtKilosS
            // 
            this.TxtKilosS.Location = new System.Drawing.Point(441, 129);
            this.TxtKilosS.Name = "TxtKilosS";
            this.TxtKilosS.Size = new System.Drawing.Size(154, 20);
            this.TxtKilosS.TabIndex = 6;
            // 
            // dataGridCafe
            // 
            this.dataGridCafe.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCafe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNcafe,
            this.ColumSecos,
            this.ColumCerezas,
            this.ColumFechacafe});
            this.dataGridCafe.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridCafe.Location = new System.Drawing.Point(62, 172);
            this.dataGridCafe.Name = "dataGridCafe";
            this.dataGridCafe.Size = new System.Drawing.Size(573, 123);
            this.dataGridCafe.TabIndex = 7;
            // 
            // ColumNcafe
            // 
            this.ColumNcafe.HeaderText = "N°Cafe ";
            this.ColumNcafe.Name = "ColumNcafe";
            this.ColumNcafe.Width = 60;
            // 
            // ColumSecos
            // 
            this.ColumSecos.HeaderText = "Secos Recolectados";
            this.ColumSecos.Name = "ColumSecos";
            this.ColumSecos.Width = 160;
            // 
            // ColumCerezas
            // 
            this.ColumCerezas.HeaderText = "Cerezas Recolectadas";
            this.ColumCerezas.Name = "ColumCerezas";
            this.ColumCerezas.Width = 160;
            // 
            // ColumFechacafe
            // 
            this.ColumFechacafe.HeaderText = "Fecha Registro ";
            this.ColumFechacafe.Name = "ColumFechacafe";
            this.ColumFechacafe.Width = 150;
            // 
            // btnregistrar_cafe
            // 
            this.btnregistrar_cafe.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnregistrar_cafe.Location = new System.Drawing.Point(193, 313);
            this.btnregistrar_cafe.Name = "btnregistrar_cafe";
            this.btnregistrar_cafe.Size = new System.Drawing.Size(120, 38);
            this.btnregistrar_cafe.TabIndex = 8;
            this.btnregistrar_cafe.Text = "Registrar";
            this.btnregistrar_cafe.UseVisualStyleBackColor = true;
            this.btnregistrar_cafe.Click += new System.EventHandler(this.btnregistrar_cafe_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(343, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Registro_Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 413);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnregistrar_cafe);
            this.Controls.Add(this.dataGridCafe);
            this.Controls.Add(this.TxtKilosS);
            this.Controls.Add(this.TxtKilosC);
            this.Controls.Add(this.txtE_cedula_A2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Cafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Cafe";
            this.Load += new System.EventHandler(this.Registro_Cafe_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_Cafe_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtE_cedula_A2;
        private System.Windows.Forms.TextBox TxtKilosC;
        private System.Windows.Forms.TextBox TxtKilosS;
        private System.Windows.Forms.DataGridView dataGridCafe;
        private System.Windows.Forms.Button btnregistrar_cafe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNcafe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumSecos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCerezas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFechacafe;
    }
}