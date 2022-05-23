using ReponedorCliente.entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReponedorCliente.datos
{
    class ClienteDAO
    {
        public static bool guardar(Cliente e)
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

        public static Cliente consultar(string id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from cliente where idCliente='"+id+"';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();
               
                Cliente cl = new Cliente();
                if (dr.Read())
                {
                    cl.IdCliente = dr["idCliente"].ToString();
                    cl.Nombre = dr["nombre"].ToString();
                    cl.Apellido = dr["apellido"].ToString();
                    cl.Telefono = dr["telefono"].ToString();
                    cl.Email = dr["email"].ToString();
                    cl.Direccion = dr["direccion"].ToString();
                    con.desconectar();
                    return cl;

                }
                else
                {
                    con.desconectar();
                    return null;
                }
                

                

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool actualizar(Cliente e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE  cliente SET nombre='" + e.Nombre + "',apellido='" + e.Apellido + "'" +
                    ",telefono='" + e.Telefono + "',email='" + e.Email + "',direccion='" + e.Direccion + "'  where idCliente = '" + e.IdCliente + "'  ";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }  
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool eliminar(string id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "DELETE  FROM  cliente  where idCliente = '" +id+ "'; ";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    con.desconectar();
                    return true;
                }
                else
                {
                    con.desconectar();
                    return false;
                }



            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
