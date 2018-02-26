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
    public partial class realizarPago : UserControl
    {
        Conexion db = new Conexion();
        public realizarPago()
        {
            InitializeComponent();
            mostrarDatos();

        }
        public void mostrarDatos()
        {
            Pagos x = db.ObtenerDatosPagos();
            total.Text = x.Salario_Pagado.ToString();
            cantidad.Text = x.Cantidad_de_Empleados.ToString();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = respUsuario.Text;
            string password = respContra.Text;

            if (username.Equals("admin") && password.Equals("1234"))
            {
                db.RegistrarPagos(db.ObtenerEmpleados());
            }

            else
            {
                MessageBox.Show("Usuario/Contraseña es incorrecto!");
            }
        }
    }
}
