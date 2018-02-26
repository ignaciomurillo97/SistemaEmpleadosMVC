using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleadosMVC.UserControlForm
{
    public partial class Buscador : UserControl
    {
        Conexion db = new Conexion();
        public Buscador()
        {
            InitializeComponent();
            muestraInfo();
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {

            db.buscarEmpleado(Convert.ToInt32(busca.Text));
            data.DataSource = db.ds.Tables["Empleado"];
        }

        private void muestraInfo()
        {
            db.infoEmpleados();
            data.DataSource = db.ds.Tables["Empleado"];
        }

        private void Enter_Click(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                db.buscarEmpleado(Convert.ToInt32(busca.Text));
                data.DataSource = db.ds.Tables["Empleado"];
            }

        }

        private void data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VentanaPrincipal padre = (this.Parent as VentanaPrincipal);

            DataGridViewRow Empleado = data.Rows[e.RowIndex];
            int cedula = Int32.Parse(Empleado.Cells["Identificación"].Value.ToString());
            padre.MostrarEmpleado(cedula);
        }
    }
}
