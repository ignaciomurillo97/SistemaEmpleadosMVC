using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleadosMVC
{
    public partial class agregarEmpleado : UserControl
    {
        Conexion db = new Conexion();
        public agregarEmpleado()
        {
            InitializeComponent();
            muestraInfoPuesto();
        }
        public void muestraInfoPuesto()
        {
            respPuesto.DataSource = db.ObtenerPuesto();
            respPuesto.DisplayMember = "Nombre_Puesto";
            respPuesto.ValueMember = "IdPuesto";
        }
        private void button1_Click(object sender, EventArgs e)
        {
             bool flag = db.agregarEmpleado(Convert.ToInt32(respCedula.Text), respNombre.Text,respApellido.Text,respCorreo.Text,Convert.ToInt32(respTelefono.Text));
             bool flag2 = db.agregarInfoLaboral(Convert.ToInt32(respPuesto.SelectedValue), Convert.ToInt32(respCedula.Text), respFechaInicio.Value);
            if (flag == false && flag2 == false)
            {
                respNombre.Clear();
                respApellido.Clear();
                respCorreo.Clear();
                respTelefono.Clear();
                respFechaInicio.ResetText();
                respSalario.Clear();
                MessageBox.Show("Se agrego empleado nuevo");
            }
            else
            {
                MessageBox.Show("Algo salio mal!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            respNombre.Clear();
            respApellido.Clear();
            respCorreo.Clear();
            respTelefono.Clear();
            respFechaInicio.ResetText();
            respSalario.Clear();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void respPuesto_onItemSelected(object sender, EventArgs e)
        {

        }

        private void respPuesto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(respPuesto.SelectedValue);
            respSalario.Text = db.obtenerSalario(x);
        }
    }
}
