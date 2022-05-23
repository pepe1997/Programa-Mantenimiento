using ReponedorCliente.entidad;
using ReponedorCliente.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReponedorCliente.formularios
{
    public partial class FrmProveedor : Form
    {
        private bool consultaPrevia = false;
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            consultaPrevia = false;
            if (tb_id_proveedor.Text != "" & tb_id_proveedor.Text.Trim().Length==5)
            {
                try
                {
                    Proveedor prov = new Proveedor();

                    prov.Id_proveedor = tb_id_proveedor.Text;
                    prov.Nombre = tb_nombre.Text;
                    prov.Direccion = tb_direccion.Text;
                    prov.Correo = tb_correo.Text;
                    prov.Telefono = tb_telefono.Text;
                    if (ProveedorTRA_DA.GuardarProveedor(prov))
                    {
                        MostrarProveedores();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Algo salio mal");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                //mensaje: id del proveedor no valido
            }
        }
        public void MostrarProveedores()
        {
            DataTable dt = ProveedorTRA_DA.Mostrar();

            if (dt == null)
            {
                MessageBox.Show("No se pudo acceder a los datos");
            }

            else
            {
                dgProveedor.DataSource = dt.DefaultView;
            }
        }
        private void CargarProveedores(object sender, EventArgs e)
        {
            MostrarProveedores();
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {
            if (tb_id_proveedor.Text!="")
            {
                Proveedor p = ProveedorTRA_DA.ConcultaProveedor(tb_id_proveedor.Text);
                if (p != null)
                {
                    tb_nombre.Text = p.Nombre;
                    tb_direccion.Text = p.Direccion;
                    tb_telefono.Text = p.Telefono;
                    tb_correo.Text = p.Correo;
                    consultaPrevia = true;
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado");
                    //LLAMAR AL BOTON LIMPIAR
                    consultaPrevia = false;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el id del proveedor");
            }
        }

        private void bt_modificar_Click(object sender, EventArgs e)
        {
            if (consultaPrevia)
            {
                if (tb_id_proveedor.Text!="")
                {
                    try
                    {
                        Proveedor pr = new Proveedor();
                        pr.Nombre = tb_nombre.Text;
                        pr.Direccion = tb_direccion.Text;
                        pr.Id_proveedor = tb_id_proveedor.Text;
                        pr.Correo = tb_correo.Text;
                        pr.Telefono = tb_telefono.Text;
                        if (ProveedorTRA_DA.ActualizarProveedor(pr))
                        {
                            MostrarProveedores();
                            Limpiar();
                            consultaPrevia=false;
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("La id no es valida");
                }
            }
            else
            {
                MessageBox.Show("Haga una consulta primero");
            }
            consultaPrevia = false;
        }
        private void Limpiar()
        {
            tb_correo.Text = "";
            tb_telefono.Text = "";
            tb_nombre.Text = "";
            tb_id_proveedor.Text = "";
            tb_direccion.Text = "";
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            consultaPrevia = false;
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            consultaPrevia = false;
            if (tb_id_proveedor.Text!="")
            {
                if (ProveedorTRA_DA.Eliminar(tb_id_proveedor.Text))
                {
                    MostrarProveedores();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("El id no existe");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una id");
            }
        }

        private void bt_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_atras_CamColor(object sender, EventArgs e)
        {
            bt_atras.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void bt_atras_CamColor1(object sender, EventArgs e)
        {
            bt_atras.BackColor = Color.Red;
        }
    }
}
