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
    public partial class HistorialVacaciones : UserControl
    {
        private Conexion db;
        private int? cedula = null;

        public HistorialVacaciones()
        {
            db = new Conexion();
            InitializeComponent();
        }

        public void llenarDatos(int cedula)
        {
            this.cedula = cedula;
            db.ObtenerHistorialVacaciones(cedula);
            TablaVacaciones.DataSource = db.ds.Tables["[Historial de Vacaciones]"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cedula == null) return;
            DateTime fechaInicio = FechaInicio.Value.Date;
            DateTime fechaFinal = FechaFinal.Value.Date;
            db.AgregarVacaciones((int) cedula, fechaInicio, fechaFinal);
            db.ObtenerHistorialVacaciones((int)cedula);
            TablaVacaciones.DataSource = db.ds.Tables["[Historial de Vacaciones]"];
        }
    }
}
