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
        Conexion db;

        public DatosEmpleados()
        {
            db = new Conexion();
            InitializeComponent();
        }

        public void LlenarCampos(int cedula)
        {
            db.buscarEmpleado(cedula);

            if (db.ds.Tables["Empleado"].Rows.Count == 0) return;

            DataRow row = db.ds.Tables["Empleado"].Rows[0];
            campoCedula.Text = row["Identificación"].ToString();
            campoNombre.Text = row["Nombre"].ToString();
            campoApellido.Text = row["Apellidos"].ToString();
            campoTelefono.Text = row["Teléfono"].ToString();
            campoCorreo.Text = row["Correo"].ToString();
        }
    }
}