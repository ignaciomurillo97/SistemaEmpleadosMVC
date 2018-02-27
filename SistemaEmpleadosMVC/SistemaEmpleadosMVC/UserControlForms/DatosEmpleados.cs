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
        private int cedula;

        public DatosEmpleados()
        {
            db = new Conexion();
            InitializeComponent();
        }

        public void LlenarCampos(int cedula)
        {
            db.buscarEmpleado(cedula);
            this.cedula = cedula;

            if (db.ds.Tables["Empleado"].Rows.Count == 0) return;

            DataRow row = db.ds.Tables["Empleado"].Rows[0];
            campoCedula.Text = row["Identificación"].ToString();
            campoNombre.Text = row["Nombre"].ToString();
            campoApellido.Text = row["Apellidos"].ToString();
            campoTelefono.Text = row["Teléfono"].ToString();
            campoCorreo.Text = row["Correo"].ToString();

            PuestoClass puesto = db.ObtenerInformacionLaboral(cedula);
            if (puesto != null)
            {
                campoPuesto.Text = puesto.Nombre_Puesto;
                campoSalario.Text = puesto.Salario_Pagado.ToString();
            }
            else
            {
                campoPuesto.Text = "Sin Puesto";
                campoSalario.Text = "Sin Puesto";
            }

            db.ObtenerDatosFamiliares(cedula);
            DatosFamiliares.DataSource = db.ds.Tables["[Información de Familiares]"];
        }

        private void botonHistorialVacaciones_Click(object sender, EventArgs e)
        {
            VentanaPrincipal padre = (this.Parent as VentanaPrincipal);
            padre.MostrarHistorialVacaciones(cedula);
        }
    }
}