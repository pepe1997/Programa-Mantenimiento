using ReponedorCliente.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReponedorCliente.entidad;
using ReponedorCliente.datos;

namespace ReponedorCliente.formularios
{
    class ClienteDB
    {
        public static bool guardar(ClaseCliente e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO cliente(idCliente, nombre, apellido, telefono, email, direccion) values('" + e.IdCliente + "','" + e.Nombre + "','" + e.Apellido + "'" +
                    ",'" + e.Telefono + "','" + e.Email + "','" + e.Direccion + "')";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                con.desconectar();

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static DataTable mostrar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from cliente";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();

                dt.Load(dr);
                con.desconectar();

                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
