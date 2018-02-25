using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmpleadosMVC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username.Equals("admin") && password.Equals("1234"))
            {

                this.Hide();
                VentanaPrincipal ventana = new VentanaPrincipal();
                ventana.Show();
                
            }
        }
        private void Enter_Click(object sender, KeyPressEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (username.Equals("admin") && password.Equals("1234"))
                {

                    this.Hide();
                    VentanaPrincipal ventana = new VentanaPrincipal();
                    ventana.Show();

                }
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
