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
    internal class TrabajadorDao
    {
        public static bool guardar(Trabajador e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT INTO Trabajador(cod_trabajador , nombre, apellido, telefono, cargo, direccion) values('" + e.Cod_trabajador + "','" + e.Nombre + "','" + e.Apellido + "'" +
                    ",'" + e.Telefono + "','" + e.Cargo + "','" + e.Direccion + "')";
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
                string sql = "select * from Trabajador";
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

        public static Trabajador consultar(string id)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "select * from Trabajador where cod_trabajador ='" + id + "';";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader();

                Trabajador cl = new Trabajador();
                if (dr.Read())
                {
                    cl.Cod_trabajador = dr["cod_trabajador"].ToString();
                    cl.Nombre = dr["nombre"].ToString();
                    cl.Apellido = dr["apellido"].ToString();
                    cl.Telefono = dr["telefono"].ToString();
                    cl.Cargo = dr["cargo"].ToString();
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

        public static bool actualizar(Trabajador e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "UPDATE  Trabajador SET nombre='" + e.Nombre + "',apellido='" + e.Apellido + "'" +
                    ",telefono='" + e.Telefono + "',cargo ='" + e.Cargo + "',direccion='" + e.Direccion + "'  where cod_trabajador   = '" + e.Cod_trabajador + "'  ";
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
                string sql = "DELETE  FROM Trabajador  where cod_trabajador  = '" + id + "'; ";
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
