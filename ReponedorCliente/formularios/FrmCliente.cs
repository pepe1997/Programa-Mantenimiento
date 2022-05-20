using ReponedorCliente.datos;
using ReponedorCliente.entidad;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdcliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un id valido");

            }
            else if(txtIdcliente.Text.Trim().Length<8)
            {
                MessageBox.Show("Debe ingresar una clave de 8 digitos ");
            }
            else
            {
                try
                {
                    Cliente cl = new Cliente();

                    cl.IdCliente = txtIdcliente.Text;
                    cl.Nombre = txtNombre.Text;
                    cl.Apellido = txtApellido.Text;
                    cl.Telefono = txtTelefono.Text;
                    cl.Email = txtEmail.Text;
                    cl.Direccion = txtDireccion.Text;

                    if (ClienteDAO.guardar(cl))
                    {
                        mostarDatos();
                        limpiarcampos();
                        MessageBox.Show("Empleado Guardoda");

                    }
                    else
                    {

                        MessageBox.Show("Ya existe ese cliente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void mostarDatos()
        {
            DataTable datos = ClienteDAO.mostrar();
            if(datos == null)
            {
                MessageBox.Show("No se pudo acceder a los datos");
            }
           
            else
            {
                dgCliente.DataSource = datos.DefaultView;
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            mostarDatos();
        }
        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdcliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            
            
        }
        public void limpiarcampos()
        {
            txtIdcliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
        }
        bool consultado = false;
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIdcliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un id valido");

            }
            else
            {
                Cliente c = ClienteDAO.consultar(txtIdcliente.Text.Trim());
                if (c == null)
                {
                    MessageBox.Show("No existe el empleado con el id" + txtIdcliente.Text);
                    limpiarcampos();
                    consultado = false;
                }
                else
                {
                    txtIdcliente.Text = c.IdCliente;
                    txtNombre.Text = c.Nombre;
                    txtApellido.Text = c.Apellido;
                    txtTelefono.Text = c.Telefono;
                    txtEmail.Text = c.Email;
                    txtDireccion.Text = c.Direccion;
                    consultado = true;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar primero al cliente");

            }
            else if (txtIdcliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un id valido");

            }
   
            else
            {
                try
                {
                    Cliente cl = new Cliente();

                    cl.IdCliente = txtIdcliente.Text;
                    cl.Nombre = txtNombre.Text;
                    cl.Apellido = txtApellido.Text;
                    cl.Telefono = txtTelefono.Text;
                    cl.Email = txtEmail.Text;
                    cl.Direccion = txtDireccion.Text;

                    if (ClienteDAO.actualizar(cl))
                    {
                        mostarDatos();
                        limpiarcampos();
                        MessageBox.Show("Empleado actualizado");
                        consultado = false;
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar primero al cliente");

            }
            else if (txtIdcliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un id valido");

            }
            else if (DialogResult.Yes == MessageBox.Show(null, "Desea eliminar el cliente ","Confirmar", MessageBoxButtons.YesNo))
            {

                try
                {
                   

                    if (ClienteDAO.eliminar(txtIdcliente.Text.Trim()))
                    {
                        mostarDatos();
                        limpiarcampos();
                        MessageBox.Show("Empleado eliminado");
                        consultado = false;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
