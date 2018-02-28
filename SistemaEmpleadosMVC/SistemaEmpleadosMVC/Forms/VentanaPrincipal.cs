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
            setBack(button1);
            agregarEmpleado2.muestraInfoPuesto();
            MostrarVista(agregarEmpleado2);
            editarEmpleado1.Hide();
            datosEmpleados1.Hide();
            buscar.Hide();
            realizarPago1.Hide();
            agregarPuesto1.Hide();
            historialVacaciones1.Hide();
            back.Hide();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            setBack(button1);
            agregarEmpleado2.muestraInfoPuesto();
            MostrarVista(agregarEmpleado2);
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            setBack(button3);
            buscar.muestraInfo();
            MostrarVista(buscar);
            
        }

        private void editar_Click(object sender, EventArgs e)
        {
            setBack(button2);
            editarEmpleado1.muestraInfoPuesto();
            editarEmpleado1.muestraInfo();

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
            Back();
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
            Back();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            setBack(button4);
            MostrarVista(realizarPago1);

        }
        //Color de pestañas
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
        //Boton de atras
        private void Back()
        {
            if (vistaActiva == historialVacaciones1 || vistaActiva == datosEmpleados1)
            {
                back.Show();
            }
            else
            {
                back.Hide();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (vistaActiva == datosEmpleados1)
            {
                MostrarVista2(buscar);
            }
            else
            {
                MostrarVista2(datosEmpleados1);
            }
        }
        public void MostrarVista2(UserControl nuevaVista)
        {
            vistaActiva?.Hide();
            efecto1.ShowSync(nuevaVista);

            vistaActiva = nuevaVista;
            Back();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}