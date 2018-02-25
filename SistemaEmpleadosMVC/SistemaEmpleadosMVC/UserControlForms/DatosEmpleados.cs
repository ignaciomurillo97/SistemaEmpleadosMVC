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
    public partial class DatosEmpleados : UserControl
    {
        Conexion db = new Conexion();

        public DatosEmpleados(int cedula)
        {
            InitializeComponent();
            LlenarCampos(cedula);
        }

        public void LlenarCampos(int cedula)
        {
            db.buscarEmpleado(cedula);
            DataRow row = db.ds.Tables["Empleado"].Rows[0];
            campoCedula.Text = row["Identificación"].ToString();
            campoNombre.Text = row["Nombre"].ToString();
            campoApellido.Text = row["Apellido"].ToString();
            campoTelefono.Text = row["Telefono"].ToString();
            campoCorreo.Text = row["Correo"].ToString();
        }
    }
}