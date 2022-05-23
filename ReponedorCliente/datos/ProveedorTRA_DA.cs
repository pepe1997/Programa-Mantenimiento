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
    internal class ProveedorTRA_DA
    {
        public static bool GuardarProveedor(Proveedor p)
        {
            try
            {
                Conexion conexion = new Conexion();
                string comando = "INSERT INTO Proveedor(idProveedor, nombre, direccion, telefono, correo) values('" + p.Id_proveedor
                    + "','" + p.Nombre + "','" + p.Direccion + "','" + p.Telefono + "','" + p.Correo + "')";
                SqlCommand exeComando = new SqlCommand(comando, conexion.conectar());
                int cantidad = exeComando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    conexion.desconectar();
                    return true;
                }
                else
                {
                    conexion.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static DataTable Mostrar()
        {
            try
            {
                Conexion conexion = new Conexion();
                string comando = "select*from Proveedor";
                SqlCommand exeComando = new SqlCommand(comando, conexion.conectar());

                SqlDataReader reader = exeComando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(reader);
                conexion.desconectar();

                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public static Proveedor ConcultaProveedor(string id)
        {
            try
            {
                Conexion conexion = new Conexion();
                string comando = "select * from Proveedor where idProveedor = '" + id + "'";
                SqlCommand exeComando = new SqlCommand(comando, conexion.conectar());
                SqlDataReader r = exeComando.ExecuteReader();
                
                Proveedor proveedor = null;
                if (r.Read())
                {
                    proveedor = new Proveedor();
                    proveedor.Id_proveedor = r["idProveedor"].ToString();
                    proveedor.Nombre = r["nombre"].ToString();
                    proveedor.Direccion = r["direccion"].ToString();
                    proveedor.Telefono = r["telefono"].ToString();
                    proveedor.Correo = r["correo"].ToString();
                }
                conexion.desconectar();
                return proveedor;

            }
            catch (Exception)
            {

                return null;
            }

        }
        public static bool ActualizarProveedor(Proveedor p)
        {
            try
            {
                Conexion conexion = new Conexion();
                string comando = "update Proveedor set nombre='"+p.Nombre+"',direccion='"+p.Direccion+"',telefono='"+
                    p.Telefono+"',correo='"+p.Correo+"'";
                SqlCommand exeComando = new SqlCommand(comando, conexion.conectar());
                int cantidad = exeComando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    conexion.desconectar();
                    return true;
                }
                else
                {
                    conexion.desconectar();
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public static bool Eliminar(String id)
        {

            try
            {
                Conexion conexion = new Conexion();
                string comando = "delete from Proveedor where idProveedor = '" + id+"'";
                SqlCommand exeComando = new SqlCommand(comando, conexion.conectar());
                int cantidad = exeComando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    conexion.desconectar();
                    return true;
                }
                else
                {
                    conexion.desconectar();
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
