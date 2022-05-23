using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReponedorCliente.datos;
using ReponedorCliente.entidad;


namespace ReponedorCliente.formularios
{
    public partial class ClienteFrancisco : Form
    {
        public ClienteFrancisco()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtcod_trabajador.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtcargo.Text = "";
            txtDireccion.Text = "";
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (consultado == false)
            {
                MessageBox.Show("Debe consultar primero al trabajador");

            }
            else if (txtcod_trabajador.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un codigo de trabajador valido");

            }
            else if (DialogResult.Yes == MessageBox.Show(null, "Desea eliminar el trabajador ", "Confirmar", MessageBoxButtons.YesNo))
            {

                try
                {


                    if (TrabajadorDao.eliminar(txtcod_trabajador.Text.Trim()))
                    {
                        mostarDatos();
                        limpiarcampos();
                        MessageBox.Show("trabajador eliminado");
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (consultado == false)
            {
                MessageBox.Show("Debe consultar primero al trabajador");

            }
            else if (txtcod_trabajador.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un codigo de trabajador valido");

            }

            else
            {
                try
                {
                    Trabajador cl = new Trabajador();

                    cl.Cod_trabajador = txtcod_trabajador.Text;
                    cl.Nombre = txtNombre.Text;
                    cl.Apellido = txtApellido.Text;
                    cl.Telefono = txtTelefono.Text;
                    cl.Cargo = txtcargo.Text;
                    cl.Direccion = txtDireccion.Text;

                    if (TrabajadorDao.actualizar(cl))
                    {
                        mostarDatos();
                        limpiarcampos();
                        MessageBox.Show("trabajador actualizado");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtcod_trabajador.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un codigo de trabajador valido");

            }
            else
            {Trabajador c = TrabajadorDao.consultar(txtcod_trabajador.Text.Trim());
                if (c == null)
                {
                    MessageBox.Show("No existe el trabajador con el codigo de trabajor" + txtcod_trabajador.Text);
                    limpiarcampos();
                    consultado = false;
                }
                else
                {
                    txtcod_trabajador.Text = c.Cod_trabajador;
                    txtNombre.Text = c.Nombre;
                    txtApellido.Text = c.Apellido;
                    txtTelefono.Text = c.Telefono;
                    txtcargo.Text = c.Cargo;
                    txtDireccion.Text = c.Direccion;
                    consultado = true;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtcod_trabajador.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un codigo de trabajador valido");

            }
            else if (txtcod_trabajador.Text.Trim().Length < 8)
            {
                MessageBox.Show("Debe ingresar una clave de 8 digitos ");
            }
            else
            {
                try
                {
                   Trabajador cl = new Trabajador();

                    cl.Cod_trabajador = txtcod_trabajador.Text;
                    cl.Nombre = txtNombre.Text;
                    cl.Apellido = txtApellido.Text;
                    cl.Telefono = txtTelefono.Text;
                    cl.Cargo = txtcargo.Text;
                    cl.Direccion = txtDireccion.Text;

                    if (TrabajadorDao.guardar(cl))
                    {
                        mostarDatos();
                        limpiarcampos();
                        MessageBox.Show("trabajador Guardado");

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
    

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClienteFrancisco_Load(object sender, EventArgs e)
        {

        }
        private void mostarDatos()
        {
            DataTable datos = TrabajadorDao.mostrar();
            if (datos == null)
            {
                MessageBox.Show("No se pudo acceder a los datos");
            }

            else
            {
                dgCliente.DataSource = datos.DefaultView;
            }
        }

        public void limpiarcampos()
        {
            txtcod_trabajador.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtcargo.Text = "";
            txtDireccion.Text = "";
        }
        bool consultado = false;
    }
}
