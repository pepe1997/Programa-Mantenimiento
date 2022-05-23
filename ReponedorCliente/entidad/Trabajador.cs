using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReponedorCliente.entidad
{
    internal class Trabajador
    {
            private string cod_trabajador;
            private string nombre;
            private string apellido;
            private string telefono;
            private string cargo;
            private string direccion;

        public Trabajador()
        {
            this.cod_trabajador ="";
            this.nombre = "";
            this.apellido = "";
            this.telefono = "";
            this.cargo = "";
            this.direccion = "";
        }

        public string Cod_trabajador { get => cod_trabajador; set => cod_trabajador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
