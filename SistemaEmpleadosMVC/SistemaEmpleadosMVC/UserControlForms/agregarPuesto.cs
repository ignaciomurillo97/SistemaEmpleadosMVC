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
    public partial class agregarPuesto : UserControl
    {
        Conexion db = new Conexion();
        int IdPuesto;
        public agregarPuesto()
        {
            InitializeComponent();
            muestraInfo();
            IdPuesto = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salario.Clear();
            puesto.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = db.agregarPuesto(puesto.Text, decimal.Parse(salario.Text));
            if (flag == false)
            {
                MessageBox.Show("Puesto agregado correctamente.");
                muestraInfo();
            }
            else
            {
                MessageBox.Show("Algo salio mal!");
            }

        }
        private void muestraInfo()
        {
            db.infoPuesto();
            data.DataSource = db.ds.Tables["Puesto"];
        }

        private void salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                bool flag = db.agregarPuesto(puesto.Text, decimal.Parse(salario.Text));
                if (flag == false)
                {
                    MessageBox.Show("Puesto agregado correctamente.");
                    muestraInfo();
                }
                else
                {
                    MessageBox.Show("Algo salio mal!");
                }
            }
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow puesto1 = data.Rows[e.RowIndex];
            IdPuesto = Convert.ToInt32(puesto1.Cells[0].Value.ToString());
            puesto.Text = puesto1.Cells[1].Value.ToString();
            salario.Text = puesto1.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.editarPuesto(Convert.ToInt32(IdPuesto), puesto.Text, decimal.Parse(salario.Text));
            muestraInfo();
        }
    }
}
