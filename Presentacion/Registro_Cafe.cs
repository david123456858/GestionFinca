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
    public partial class Registro_Cafe : Form
    {
        public Log_in logInForm;
        public Registro_Cafe()
        {
            InitializeComponent();
        }

        ICafe ServiciosCafe = new ICafe();  //CAFE A RECOGER

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Registro_Cafe_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        private void btnregistrar_cafe_Click(object sender, EventArgs e)
        {
            RegistroCafe();
        }

        void RegistroCafe()
        {
            Logica.ICafe icafe = new Logica.ICafe();
            var cafe = new Reg_Cafés();

            cafe.CC_ADMIN = txtE_cedula_A2.Text;
            cafe.Cereza_Kilos = TxtKilosC.Text;
            cafe.Secos_Kilos = TxtKilosS.Text;
            var estado = icafe.Add(cafe);
            MessageBox.Show(estado.ToString());
            LimpiarCamposCafe();
        }

        void VerDatosCafe()
        {
            var lista = ServiciosCafe.GetAll(txtE_cedula_A2.Text);
            dataGridCafe.Rows.Clear();

            foreach (var item in lista)
            {
                dataGridCafe.Rows.Add(new object[]
                {
                    item.id_cafe,
                    item.Cereza_Kilos,
                    item.Secos_Kilos,
                    item.Fecha
                });
            }
        }

        void LimpiarCamposCafe()
        {
            TxtKilosC.Clear();
            TxtKilosS.Clear();
        }

        private void Registro_Cafe_Load(object sender, EventArgs e)
        {
            txtE_cedula_A2.Text = logInForm.Admint;
            VerDatosCafe();
        }
        void Actualiza()
        {
            Logica.ICafe icafe = new Logica.ICafe();
            var cafe = new Reg_Cafés();

            cafe.CC_ADMIN = txtE_cedula_A2.Text;
            cafe.Cereza_Kilos = TxtKilosC.Text;
            cafe.Secos_Kilos = TxtKilosS.Text;
            var estado = icafe.Actualizar(cafe);
            MessageBox.Show(estado.ToString());
            LimpiarCamposCafe();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Actualiza();
        }
    }
}