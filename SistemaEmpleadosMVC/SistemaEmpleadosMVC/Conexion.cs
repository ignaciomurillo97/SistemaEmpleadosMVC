using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace SistemaEmpleadosMVC
{
    class Conexion
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-5NI87TD;Initial Catalog=Empleados Diseño;Integrated Security=True");
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand command;

        public void connect()
        {
            try
            {
                connection.Open();

            }
            catch
            {
                MessageBox.Show("Ocurrio un problema con la conexion");
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Ejecutar(string sql)
        {
            connection.Open();
            command = new SqlCommand(sql, connection);
            int x = command.ExecuteNonQuery();
            connection.Close();
            if (x < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void infoEmpleados()
        {
            string sql = "select * from Empleado";
            string tabla = "Empleado";
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, connection);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);

        }

        public bool update(string sql)
        {
            connection.Open();

            command = new SqlCommand(sql, connection);
            int x = command.ExecuteNonQuery();
            connection.Close();
            if (x < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<PuestoClass> ObtenerPuesto()
         {
             List<PuestoClass> listaPuesto = new List<PuestoClass>();
             connection.Open();
             SqlCommand comando = new SqlCommand("select * from Puesto", connection);
             SqlDataReader read = comando.ExecuteReader();
             while (read.Read())
             {
                 PuestoClass qPuesto = new PuestoClass();
                 int x = int.Parse(read["IdPuesto"].ToString());

                 decimal y = decimal.Parse(read["Salario Pagado"].ToString());
                 qPuesto.IdPuesto = x;
                 qPuesto.Nombre_Puesto = read["Nombre Puesto"].ToString();
                 qPuesto.Salario_Pagado = y;
                 listaPuesto.Add(qPuesto);
             }
             connection.Close();
             return listaPuesto;
         } 

        public string obtenerSalario(int IdPuesto)
        {
            string salario = "";
            connection.Open();
            SqlCommand comando = new SqlCommand("select * from Puesto where IdPuesto=" + IdPuesto, connection);
            SqlDataReader read = comando.ExecuteReader();
            while (read.Read())
            {
                salario = read["Salario Pagado"].ToString();
            }
            connection.Close();


            return salario;
        }

        public bool agregarEmpleado(int respCedula, string respNombre, string respApellido, string respCorreo, int respTelefono)
        {
            string sql = "insert into Empleado(Identificación, Nombre, Apellidos,  Correo, Teléfono) " +
                "values(" + respCedula + ",'" + respNombre + "','" + respApellido + "','" +
                respCorreo + "'," + respTelefono + ")";
            return Ejecutar(sql);
        }

        public bool agregarInfoLaboral(int respPuesto, int respCedula,  DateTime respFechaInicio)
        {
            string sql = "insert into [Información Laboral](IdPuesto, IdEmpleado, [Fecha Inicio]) " +
                "values(" + respPuesto + "," + respCedula+ ", '" + respFechaInicio + "')";
            return Ejecutar(sql);        
        }

        public bool editarEmpleado(int respCedula, string respNombre, string respApellido, int respTelefono, string respCorreo, int respPuesto)
        {
            string sql = "update Empleado set Identificación= " + respCedula + ", Nombre='" + respNombre + "', Apellidos='" +
                respApellido + "', Teléfono= " + respTelefono + ", Correo= '" + respCorreo + "'  where Identificación = " + respCedula;
            editarInfoLaboral(respPuesto, respCedula);
            connection.Open();
            command = new SqlCommand(sql, connection);
           
            int x = command.ExecuteNonQuery();
            connection.Close();
            if (x < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void editarInfoLaboral(int respPuesto, int respCedula)
        {
            string sql = "update [Información Laboral] set IdPuesto= " + respPuesto + "  where IdEmpleado = " + respCedula;
            connection.Open();
            command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        public void buscarEmpleado(int respCedula)
        {
            string sql = "select * from Empleado where Identificación = " + respCedula;
       
            string tabla = "Empleado";
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, connection);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

    }
}