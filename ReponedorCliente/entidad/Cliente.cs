using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReponedorCliente.entidad
{
    class Cliente
    {
        private string idCliente;
        private string nombre;
        private string apellido;
        private string telefono;
        private string email;
        private string direccion;




        public Cliente()
        {
            this.idCliente = "";
            this.nombre = "";
            this.apellido = "";
            this.telefono = "";
            this.email = "";
            this.direccion = "";

        }

        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }

    }
}
