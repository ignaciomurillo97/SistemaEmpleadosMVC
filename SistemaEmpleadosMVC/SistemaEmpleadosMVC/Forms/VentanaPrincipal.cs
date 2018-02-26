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

        public VentanaPrincipal()
        {
            InitializeComponent();
            agregarEmpleado2.Hide();
            editarEmpleado1.Hide();
            buscar.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarVista(agregarEmpleado2);
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            mostrarVista(buscar);
        }

        private void editar_Click(object sender, EventArgs e)
        {
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
            DialogResult result = MessageBox.Show("Seguro que desea realizar pago de todos los usuarios?", "Pago Mensual",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.OK)
            {
                //Pagar :v
            }
            
        }
    }
}