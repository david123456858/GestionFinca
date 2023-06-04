using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Registro_Escogidos : Form
    {
        public Log_in logInForm;
        public Registro_Escogidos()
        {
            InitializeComponent();
        }

        ICafe_Escogido ServicioCafeEscogido = new ICafe_Escogido(); //SERVICIO EL CUAL ACUMULA LO QUE SE TOMÓ POR CEDULA EN UNA FECHA

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Registro_Escogidos_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        private void btnRegisEsCo_Click(object sender, EventArgs e)
        {
            RegistrosEscogidos();
            
        }

        void RegistrosEscogidos()
        {
            var escogido = new Reg_Escogidos();
            escogido.CC_ADMIN = txtE_cedula_A3.Text;
            escogido.Cedula_Empleado = TxtCC.Text;
            escogido.cantidad = decimal.Parse(TxtCantEsco.Text);
            escogido.Fecha = DateTime.Parse(FechaRegisEscogidos.Text);
            var estado = ServicioCafeEscogido.Add(escogido);
            MessageBox.Show(estado.ToString());
            LimpiarRegisEscogidos();
            
        }

        void VerDatosRegisEsc()
        {
            var lista = ServicioCafeEscogido.GetAll(txtE_cedula_A3.Text);
            c.Rows.Clear();
            foreach (var item in lista) {

                c.Rows.Add(new object[]
                {
                    item.id_escogido,
                    item.Cedula_Empleado,
                    item.cantidad,
                    item.Fecha
                });
            
            }
        }

        void LimpiarRegisEscogidos()
        {
            TxtCC.Clear();
            TxtCantEsco.Clear();
            txtE_cedula_A3.Clear();
        }
        void Actualizar()
        {
            var escogido = new Reg_Escogidos();
            escogido.CC_ADMIN = txtE_cedula_A3.Text;
            escogido.Cedula_Empleado = TxtCC.Text;
            escogido.cantidad = decimal.Parse(TxtCantEsco.Text);
            escogido.Fecha = DateTime.Parse(FechaRegisEscogidos.Text);
            var estado = ServicioCafeEscogido.Actualizar(escogido);
            MessageBox.Show(estado.ToString());
            LimpiarRegisEscogidos();
        }
        private void Registro_Escogidos_Load(object sender, EventArgs e)
        {
            txtE_cedula_A3.Text = logInForm.Admint;
            VerDatosRegisEsc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}