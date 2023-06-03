using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Nomina : Form
    {
        INomina nominas = new INomina();
        public Log_in logInForm;
        public Nomina()
        {
            InitializeComponent();
        }
        void LimpiarDatos()
        {
            txtFNvalordia.Clear();

        }
        void VerDatos()
        {
            List<Entidades.Nomina> nomina = nominas.GetAll(txt_FNcedulaA.Text);
            foreach (var item in nomina)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    item.id_nomina,
                    item.CC_Empleado,
                    item.Nombre,
                    item.Apellido,
                    item.Total_Kilos,
                    item.Total_Pedidos,
                    item.Salario_Base,
                    item.Total_pagado
                });
            }
        }
        void RegistrarDatos()
        {
            Entidades.Nomina nomina = new Entidades.Nomina();
            nomina.CC_Empleado = txtFN_cedulaE.Text;
            nomina.Salario_Base = decimal.Parse(txtFNvalordia.Text);
            nomina.Fecha_nomina = DateTime.Parse(dateTimePicker1.Text);
            var estado = nominas.Add(nomina);
            MessageBox.Show(estado.ToString());
            LimpiarDatos();
        }
        private void Nomina_Load(object sender, EventArgs e)
        {
            txt_FNcedulaA.Text = logInForm.Admint;
            VerDatos();
            
        }

        private void btn_FNregistrar_Click(object sender, EventArgs e)
        {
            RegistrarDatos();
        }
    }
}
