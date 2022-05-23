
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReponedorCliente.entidad
{
    class Proveedor
    {
        private string id_proveedor;
        private string nombre;
        private string direccion;
        private string telefono;
        private string correo;
        public Proveedor()
        {
            this.id_proveedor = "";
            this.nombre = "";
            this.direccion = "";
            this.telefono = "";
            this.correo = "";
        }
        public string Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Nombre { get => nombre; set => nombre = value;}
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value;}
        public string Correo { get => correo; set => correo = value; }


    }
}
