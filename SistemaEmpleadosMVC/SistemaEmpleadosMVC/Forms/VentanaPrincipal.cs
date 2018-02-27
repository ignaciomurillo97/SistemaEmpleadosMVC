using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            buscar.Hide();
            realizarPago1.Hide();
            agregarPuesto1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setBack(button1);
            mostrarVista(agregarEmpleado2);
           
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            setBack(button3);
            mostrarVista(buscar);
        }

        private void editar_Click(object sender, EventArgs e)
        {
            setBack(button2);
            mostrarVista(editarEmpleado1);
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

        private void mostrarVista (UserControl nuevaVista)
        {
            if (vistaActiva != null)
            {
                vistaActiva.Hide();
            }
            transicion.ShowSync(nuevaVista);
            vistaActiva = nuevaVista;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setBack(button4);
            mostrarVista(realizarPago1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            setBack(button5);
            mostrarVista(agregarPuesto1);
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