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
using Logica;
using Entidades;

namespace Presentacion
{
    public partial class ManejoAdmin : Form
    {
        public ManejoAdmin()
        {
            InitializeComponent();
        }

        ICafe ServiciosCafe = new ICafe();  //CAFE A RECOGER
        IVentas ServicioVentas = new IVentas(); //SERVICIO DE VENTAS
        ICafe_Escogido ServicioCafeEscogido = new ICafe_Escogido(); //SERVICIO EL CUAL ACUMULA LO QUE SE TOMÓ POR CEDULA EN UNA FECHA
        IEmpleados ServicioEmpleados = new IEmpleados(); //SERVICIO PARA REGISTRO DE EMPLEADOS

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ManejoAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        private void btnRegisCafe_Click(object sender, EventArgs e)
        {
            RegistroCafe();
        }

        private void btnRegistrarVentas_Click(object sender, EventArgs e)
        {
            RegistroVentas();
        }

        private void btnRegisEsCo_Click(object sender, EventArgs e)
        {
            RegistrosEscogidos();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEmpleados_Click(object sender, EventArgs e)
        {
            RegistroEmpleados();
        }

        void RegistroCafe()
        {
            if (string.IsNullOrEmpty(TxtKilosC.Text) || (string.IsNullOrEmpty(TxtKilosS.Text)))
            {

                MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS");
            }
            else
            {
                try
                {
                    Registrado_Cafe cafe = new Registrado_Cafe();

                    cafe.Kilos_secos = int.Parse(TxtKilosS.Text.Trim());
                    cafe.Kilos_cereza = int.Parse((TxtKilosC.Text).Trim());
                    cafe.Fecha = FechaK.Value;

                    string respuesta = ServiciosCafe.Add(cafe);

                    MessageBox.Show(respuesta);
                    VerDatosCafe();
                    LimpiarCamposCafe();
                }

                catch (Exception)
                {
                    MessageBox.Show("ERROR AL REGISTRAR CAFE");
                }
            }
        }

        void VerDatosCafe()
        {
            List<Registrado_Cafe> ListCafe = ServiciosCafe.GetAll();

            if ((ListCafe == null) || (ListCafe.Count == 0))
            {
                return;
            }
            else
            {
                dataGridCafe.Rows.Clear();
                foreach (var cafe in ListCafe)
                {

                    DataGridViewRow fila = new DataGridViewRow(); //CREAR NUEVA FILA PARA EL DATAGRIW

                    // Agregar las celdas a la fila
                    DataGridViewCell CeldCereza = new DataGridViewTextBoxCell();
                    CeldCereza.Value = cafe.Kilos_cereza;
                    fila.Cells.Add(CeldCereza);

                    DataGridViewCell CeldSecos = new DataGridViewTextBoxCell();
                    CeldSecos.Value = cafe.Kilos_secos;
                    fila.Cells.Add(CeldSecos);

                    DataGridViewCell CeldFecha = new DataGridViewTextBoxCell();
                    CeldFecha.Value = cafe.Fecha.ToShortDateString();
                    fila.Cells.Add(CeldFecha);


                    dataGridCafe.Rows.Add(fila); //agregar las filas al datagriw
                }
            }
        }

        void LimpiarCamposCafe()
        {
            TxtKilosC.Clear();
            TxtKilosS.Clear();
        }

        void VerDatosVentas()
        {
            List<Registro_Ventas> ListVenta = ServicioVentas.GetAll();

            if ((ListVenta == null) || (ListVenta.Count == 0))
            {
                return;
            }
            else
            {
                dataGridVenta.Rows.Clear();
                foreach (var Venta in ListVenta)
                {
                    DataGridViewRow fila = new DataGridViewRow(); //CREAR NUEVA FILA PARA EL DATAGRIW

                    // Agregar las celdas a la fila
                    DataGridViewCell CeldRef = new DataGridViewTextBoxCell();
                    CeldRef.Value = Venta.Id_ventas;
                    fila.Cells.Add(CeldRef);

                    DataGridViewCell CeldFactor = new DataGridViewTextBoxCell();
                    CeldFactor.Value = Venta.Factor;
                    fila.Cells.Add(CeldFactor);

                    DataGridViewCell CeldValorKilos = new DataGridViewTextBoxCell();
                    CeldValorKilos.Value = Venta.Valor_Kilo;
                    fila.Cells.Add(CeldValorKilos);

                    DataGridViewCell CeldKilos = new DataGridViewTextBoxCell();
                    CeldKilos.Value = Venta.Kilos;
                    fila.Cells.Add(CeldKilos);

                    DataGridViewCell CeldTotal = new DataGridViewTextBoxCell();
                    CeldTotal.Value = Venta.Total;
                    fila.Cells.Add(CeldTotal);

                    DataGridViewCell CeldFecha = new DataGridViewTextBoxCell();
                    CeldFecha.Value = Venta.Fecha.ToShortDateString();
                    fila.Cells.Add(CeldFecha);

                    dataGridVenta.Rows.Add(fila); //agregar las filas al datagriw
                }
            }
        }


        void RegistroVentas()
        {
            if (string.IsNullOrEmpty(TxtRef.Text) || (string.IsNullOrEmpty(TxtKilosL.Text)) || (string.IsNullOrEmpty(TxtValorxK.Text)) || (string.IsNullOrEmpty(TxtFactor.Text)) /*|| (string.IsNullOrEmpty(TxtTotalP.Text))*/)
            {
                MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS");
            }
            else
            {
                try
                {
                    Registro_Ventas Venta = new Registro_Ventas();

                    Venta.Id_ventas = TxtRef.Text.Trim();
                    Venta.Kilos = float.Parse(TxtKilosL.Text.Trim());
                    Venta.Valor_Kilo = float.Parse(TxtValorxK.Text.Trim());
                    Venta.Factor = TxtFactor.Text.Trim();
                    Venta.Fecha = FechaVentas.Value;
                    //Venta.Total = decimal.Parse(TxtTotalP.Text.Trim());

                    string respuesta = ServicioVentas.Add(Venta);

                    MessageBox.Show(respuesta);
                    LimpiarCamposVentas();
                    VerDatosVentas();
                }

                catch (Exception)
                {
                    MessageBox.Show("ERROR AL REGISTRAR VENTA");
                }
            }
        }


        void LimpiarCamposVentas()
        {
            TxtRef.Clear();
            TxtKilosL.Clear();
            TxtValorxK.Clear();
            TxtFactor.Clear();
            //TxtTotalP.Clear();
        }

        void RegistrosEscogidos()
        {
            if (string.IsNullOrEmpty(TxtCC.Text) || (string.IsNullOrEmpty(TxtCantEsco.Text)))
            {

                MessageBox.Show("POR FAVOR LLENE TODOS LOS CAMPOS");
            }
            else
            {
                try
                {
                    Empleado_Escogidos Empleado = new Empleado_Escogidos();

                    Empleado.Cc_empleado = TxtCC.Text;
                    Empleado.cantidad = float.Parse(TxtCantEsco.Text);
                    Empleado.FechaEscogido = FechaRegisEscogidos.Value;

                    string respuesta = ServicioCafeEscogido.Add(Empleado);

                    MessageBox.Show(respuesta);
                    LimpiarRegisEscogidos();
                    VerDatosRegisEsc();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR DE REGISTRO");
                }
            }
        }

        void VerDatosRegisEsc()
        {
            List<Empleado_Escogidos> ListRegisEsc = ServicioCafeEscogido.GetAll();

            if ((ListRegisEsc == null) || (ListRegisEsc.Count == 0))
            {
                return;
            }
            else
            {
                dataGridRegisEsc.Rows.Clear();
                foreach (var Regis in ListRegisEsc)
                {

                    DataGridViewRow fila = new DataGridViewRow(); //CREAR NUEVA FILA PARA EL DATAGRIW

                    // Agregar las celdas a la fila
                    DataGridViewCell CeldCC = new DataGridViewTextBoxCell();
                    CeldCC.Value = Regis.Cc_empleado;
                    fila.Cells.Add(CeldCC);

                    DataGridViewCell CeldCant = new DataGridViewTextBoxCell();
                    CeldCant.Value = Regis.cantidad;
                    fila.Cells.Add(CeldCant);

                    DataGridViewCell CeldFecha = new DataGridViewTextBoxCell();
                    CeldFecha.Value = Regis.FechaEscogido.ToShortDateString();
                    fila.Cells.Add(CeldFecha);

                    dataGridRegisEsc.Rows.Add(fila); //agregar las filas al datagriw
                }
            }
        }

        void LimpiarRegisEscogidos()
        {
            TxtCC.Clear();
            TxtCantEsco.Clear();
        }

        void RegistroEmpleados()
        {
            if (string.IsNullOrEmpty(TxtId.Text) || (string.IsNullOrEmpty(TxtPnombre.Text)) || (string.IsNullOrEmpty(TxtPapellido.Text)))
            {
                MessageBox.Show("N IDENTIFICACION, 1° NOMBRE Y 1° APELLIDO SON OBLIGATORIOS");
            }
            else
            {

                if (string.IsNullOrEmpty(TxtSnombre.Text))
                {
                    TxtSnombre.Text = " ";
                }
                else if (string.IsNullOrEmpty(TxtSapellido.Text)) 
                { 
                    TxtSapellido.Text = " "; 
                }
                try
                {
                    Empleado empleado = new Empleado();

                    empleado.CC = TxtId.Text;
                    empleado.name_1 = TxtPnombre.Text;
                    empleado.name_2 = TxtSnombre.Text;
                    empleado.apellido_1 = TxtPapellido.Text;
                    empleado.apellido_2 = TxtSapellido.Text;
                    //empleado.edad = txtEdad.Text;
                    empleado.FechaInicio = FechaEmpleado.Value;

                    string respuesta = ServicioEmpleados.Add(empleado);

                    MessageBox.Show(respuesta);
                    LimpiarCampoEmpleados();
                    VerDatosEmpleados();
                }

                catch (Exception)
                {
                    MessageBox.Show("ERROR DE REGISTRO DE EMPLEADO");
                }
            }
        }

        void VerDatosEmpleados()
        {
            List<Empleado> Listempleado = ServicioEmpleados.GetAll();

            if ((Listempleado == null) || (Listempleado.Count == 0))
            {
                return;
            }
            else
            {
                dataGridEmpleado.Rows.Clear();
                foreach (var empleado in Listempleado)
                {

                    DataGridViewRow fila = new DataGridViewRow(); //CREAR NUEVA FILA PARA EL DATAGRIW

                    // Agregar las celdas a la fila
                    DataGridViewCell CeldID = new DataGridViewTextBoxCell();
                    CeldID.Value = empleado.CC;
                    fila.Cells.Add(CeldID);

                    DataGridViewCell CeldPN = new DataGridViewTextBoxCell();
                    CeldPN.Value = empleado.name_1;
                    fila.Cells.Add(CeldPN);

                    DataGridViewCell CeldSN = new DataGridViewTextBoxCell();
                    CeldSN.Value = empleado.name_2;
                    fila.Cells.Add(CeldSN);

                    DataGridViewCell CeldPA = new DataGridViewTextBoxCell();
                    CeldPA.Value = empleado.apellido_1;
                    fila.Cells.Add(CeldPA);

                    DataGridViewCell CeldSA = new DataGridViewTextBoxCell();
                    CeldSA.Value = empleado.apellido_2;
                    fila.Cells.Add(CeldSA);

                    DataGridViewCell CeldFecha = new DataGridViewTextBoxCell();
                    CeldFecha.Value = empleado.FechaInicio.ToShortDateString();
                    fila.Cells.Add(CeldFecha);

                    dataGridEmpleado.Rows.Add(fila); //agregar las filas al datagriw
                }
            }
        }

        void LimpiarCampoEmpleados()
        {
            TxtId.Clear();
            TxtPnombre.Clear();
            TxtSnombre.Clear();
            TxtPapellido.Clear();
            TxtSapellido.Clear();
            //txtEdad.Clear();
        }

        private void ManejoAdmin_Load(object sender, EventArgs e)
        {
            VerDatosCafe();
            VerDatosEmpleados();
            VerDatosRegisEsc();
            VerDatosVentas();
        }
    }
}