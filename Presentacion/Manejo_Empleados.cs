using Entidades;
using Logica;
using System;
using System.Collections;
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
    public partial class Manejo_Empleados : Form
    {
        public Log_in logInForm;
        public Manejo_Empleados()
        {
            InitializeComponent();
        }

        IEmpleados ServicioEmpleados = new IEmpleados();

        private void btnRegistrarEmpleados_Click(object sender, EventArgs e)
        {
            RegistroEmpleados();
        }

        void RegistroEmpleados()
        {

            Logica.IEmpleados iempleados = new Logica.IEmpleados();
            var empleado = new Empleado();

            empleado.CC_ADMIN = txtE_cedula_A.Text;
            empleado.cedula = txtE_cedula.Text;
            empleado.nombre = txtE_nombre.Text;
            empleado.nombre2 = txtE_nombre2.Text;
            empleado.apellido = txtE_apellido.Text;
            empleado.apellido2 = txtE_apellido2.Text;
            var estado = iempleados.Add(empleado);
            MessageBox.Show(estado.ToString());
            LimpiarCampoEmpleados();
        }

        void VerDatosEmpleados()
        {
            List<Empleado> lista = ServicioEmpleados.GetAll(txtE_cedula_A.Text);
            
                
                foreach (var item in lista)
                {
                 
                    dataGridEmpleado.Rows.Add(new object[]
                    {
                        item.cedula,
                        item.nombre,
                        item.nombre2,
                        item.apellido,
                        item.apellido2,
                        item.FechaInicio
                    }
                    );
                }
            
        }

        void LimpiarCampoEmpleados()
        {
            txtE_cedula.Clear();
            txtE_nombre.Clear();
            txtE_nombre2.Clear();
            txtE_apellido.Clear();
            txtE_apellido2.Clear();
        }

        private void Manejo_Empleados_Load(object sender, EventArgs e)
        {
            txtE_cedula_A.Text = logInForm.Admint;
            VerDatosEmpleados();
        }

        private void txtbusquedaE_TextChanged(object sender, EventArgs e)
        {
            if(txtbusquedaE.Text == "")
            {
                VerDatosEmpleados();
            }
            else
            {
                var busqueda = ServicioEmpleados.BuscarPorTodo(txtbusquedaE.Text);
                foreach (var item in busqueda)
                {
                    dataGridEmpleado.Rows.Clear();
                    dataGridEmpleado.Rows.Add(new object[]
                    {
                        item.cedula,
                        item.nombre,
                        item.nombre2,
                        item.apellido,
                        item.apellido2,
                        item.FechaInicio
                    }
                    );
                }
            }
           

        }

        private void btnRegistrarEmpleados_Click_1(object sender, EventArgs e)
        {
            RegistroEmpleados();
        }
    }
}