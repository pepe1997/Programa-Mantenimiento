using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReponedorCliente.datos;
using ReponedorCliente.entidad;

namespace ReponedorCliente.entidad
{
    class ClaseCliente
    {
        private string idCliente;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private string direccion;




        public ClaseCliente()
        {
            this.idCliente = "";
            this.nombre = "";
            this.apellido = "";
            this.telefono = "";
            this.email = "";
            this.direccion = "";

        }

        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
}
