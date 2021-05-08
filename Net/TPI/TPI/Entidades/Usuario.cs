using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Entidades
{
    public class Usuario
    {
        private string NombreUsu;
        private string ContraseñaUsu;

        public Usuario(string nombreUsuario, string contraseña) 
            {
                NombreUsu = nombreUsuario;
                Contraseña = contraseña;
            }
        
        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }
        public string Contraseña
        {
            get => ContraseñaUsu;
            set => ContraseñaUsu = value;
        }
            
    

    }
}
