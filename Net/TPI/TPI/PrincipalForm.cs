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
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario usu)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: "+usu.NombreDeUsuario;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
