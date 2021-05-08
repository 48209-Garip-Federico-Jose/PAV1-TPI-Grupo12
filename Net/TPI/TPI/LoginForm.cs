using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Entidades;

namespace TPI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }


        private void btnIngresarClick(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(txtNombreUsu.Text, txtContraseña.Text);
            
            
            if (usu.NombreDeUsuario.Equals("") || usu.Contraseña.Equals(""))
            {
                MessageBox.Show("Tiene que ingresar un nombre y una contraseña");
            }
            else if (usu.NombreDeUsuario.Equals("grupo12") && usu.Contraseña.Equals("123"))
            {
                PrincipalForm ventana = new PrincipalForm(usu);
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
