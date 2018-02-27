using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEmpleadosMVC.UserControlForms;

namespace SistemaEmpleadosMVC
{
    public partial class VentanaPrincipal : Form
    {
        UserControl vistaActiva;
        Button botonActivo;
        public VentanaPrincipal()
        {
            InitializeComponent();
            agregarEmpleado2.Hide();
            editarEmpleado1.Hide();
            datosEmpleados1.Hide();
            buscar.Hide();
            realizarPago1.Hide();
            agregarPuesto1.Hide();
            historialVacaciones1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setBack(button1);
            MostrarVista(agregarEmpleado2);
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            setBack(button3);
            MostrarVista(buscar);
        }

        private void editar_Click(object sender, EventArgs e)
        {
            setBack(button2);
            MostrarVista(editarEmpleado1);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.Exit();
        }

        private void buscar_Load(object sender, EventArgs e)
        {

        }

        public void MostrarEmpleado (int cedula)
        {
            datosEmpleados1.LlenarCampos(cedula);
            MostrarVista(datosEmpleados1);
        }

        public void MostrarHistorialVacaciones(int cedula)
        {
            historialVacaciones1.llenarDatos(cedula);
            MostrarVista(historialVacaciones1);
        }

        public void MostrarVista (UserControl nuevaVista)
        {
            vistaActiva?.Hide();
            transicion.ShowSync(nuevaVista);
            vistaActiva = nuevaVista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setBack(button4);
            MostrarVista(realizarPago1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            setBack(button5);
            MostrarVista(agregarPuesto1);
        }
        public void setBack(Button pboton)
        {
            if (botonActivo != null)
            {
                botonActivo.BackColor = Color.DodgerBlue;
            }
            pboton.BackColor = Color.LightSkyBlue;
            botonActivo = pboton;

        }

    }
}