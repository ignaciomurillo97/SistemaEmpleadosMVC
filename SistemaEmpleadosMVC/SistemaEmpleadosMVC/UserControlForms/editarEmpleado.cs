using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleadosMVC.UserControlForms
{
    public partial class editarEmpleado : UserControl
    {
        Conexion db = new Conexion();
        public editarEmpleado()
        {
            InitializeComponent();
            muestraInfo();
            muestraInfoPuesto();
        }
        public void muestraInfoPuesto()
        {
            respPuesto.DataSource = db.ObtenerPuesto();
            respPuesto.DisplayMember = "Nombre_Puesto";
            respPuesto.ValueMember = "IdPuesto";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void editarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = db.editarEmpleado(Convert.ToInt32(respCedula.Text), respNombre.Text, respApellidos.Text, Convert.ToInt32(respTelefono.Text), respCorreo.Text, Convert.ToInt32(respPuesto.SelectedValue));
            if (flag == false)
            {
                MessageBox.Show("Empleado modificado correctamente");
                muestraInfo();
                respCedula.Clear();
                respNombre.Clear();
                respApellidos.Clear();
                respTelefono.Clear();
                respCorreo.Clear();
                respSalario.Clear();
            }
            else
            {
                MessageBox.Show("Algo salio mal!");
            }
        }
        public void muestraInfo()
        {
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            db.infoEmpleados();
            data.DataSource = db.ds.Tables["Empleado"];
           
        }
        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow person = data.Rows[e.RowIndex];
            respNombre.Text = person.Cells[1].Value.ToString();
            respApellidos.Text = person.Cells[2].Value.ToString();
            respTelefono.Text = person.Cells[3].Value.ToString();
            respCorreo.Text = person.Cells[4].Value.ToString();
            respCedula.Text = person.Cells[0].Value.ToString();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click_1(object sender, EventArgs e)
        {
            if (buscador.Text != "")
            {
                db.buscarEmpleado(Convert.ToInt32(buscador.Text));
                data.DataSource = db.ds.Tables["Empleado"];
            }
            else
            {
                db.infoEmpleados();
                data.DataSource = db.ds.Tables["Empleado"];
            }
           
        }
        private void respPuesto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(respPuesto.SelectedValue);
            respSalario.Text = db.obtenerSalario(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            respNombre.Clear();
            respApellidos.Clear();
            respTelefono.Clear();
            respCorreo.Clear();
            respCedula.Clear();
            respSalario.Clear();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Enter_Click(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (buscador.Text != "")
                {
                    db.buscarEmpleado(Convert.ToInt32(buscador.Text));
                    data.DataSource = db.ds.Tables["Empleado"];
                }
                else
                {
                    db.infoEmpleados();
                    data.DataSource = db.ds.Tables["Empleado"];
                }
            }

        }
    }
}
