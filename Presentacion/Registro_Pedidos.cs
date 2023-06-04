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
    public partial class Registro_Pedidos : Form
    {
        public Log_in logInForm;
        IPedidos pedido = new IPedidos();
        public Registro_Pedidos()
        {
            InitializeComponent();
        }

        private void btn_crearfacturaP_Click(object sender, EventArgs e)
        {
            RegistrarPedido();
        }
        void RegistrarPedido()
        {
            var pedidos = new Pedidos();
            pedidos.Id_pedido = txtNfacturaP.Text;
            pedidos.fecha = DateTime.Parse(dateTimePicker1.Text);
            var estado = pedido.Add(pedidos);
            MessageBox.Show(estado.ToString());
            LimpiarDatos();
        }
        void LimpiarDatos()
        {
            txtNfacturaP.Clear();
            txtRefFacturaP.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }
        void RegistrarDetalle()
        {
            var pedidos = new Detalle_Pedidos();
            pedidos.Id_pedido = txtRefFacturaP.Text;
            pedidos.cedula_empleado = textBox1.Text;
            pedidos.id_producto = textBox2.Text;
            pedidos.cantidad = int.Parse(textBox4.Text);
            var estado = pedido.add(pedidos);
            MessageBox.Show(estado.ToString());
            LimpiarDatos();
        }
        void VerDatosPedido()
        {
            var lista = pedido.GetAll(logInForm.Admint);
            dataGridView1.Rows.Clear();
            foreach (var item in lista)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    item.Id_pedido,
                    item.Nombre_producto,
                    item.Nombre_empleado,
                    item.apellido,
                    item.total,
                    item.fecha
                });
            }
        }
        private void btn_agregarP_Click(object sender, EventArgs e)
        {
            RegistrarDetalle();
        }

        private void Registro_Pedidos_Load(object sender, EventArgs e)
        {
            VerDatosPedido();
        }
    }
}
