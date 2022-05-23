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
    public partial class REGISTRAR : Form
    {
        public REGISTRAR()
        {
            InitializeComponent();
        }

        private bool validardireccion() //VALIDAR DIRECCION DEL CLIENTE
        {
            if (string.IsNullOrEmpty(txtdireccion.Text))
            {
                erpError.SetError(txtdireccion, "Debe ingresar una direccion valida");
                return false;
            }
            else
            {
                erpError.SetError(txtdireccion, "");
                return true;
            }
        }

        private bool validaremail() //VALIDAR EMAIL DEL CLIENTE
        {
            if (string.IsNullOrEmpty(txtemail.Text))
            {
                erpError.SetError(txtemail, "Debe ingresar un email valido");
                return false;
            }
            else
            {
                erpError.SetError(txtemail, "");
                return true;
            }
        }

        private bool validartelefono() //VALIDAR TELEFONO DEL CLIENTE
        {
            int tlf;
            if (!int.TryParse(txttelefono.Text, out tlf) || txttelefono.Text == "")
            {
                erpError.SetError(txttelefono, "Debe ingresar numero telefonico valido");
                txttelefono.Clear();
                txttelefono.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txttelefono, "");
                return true;
            }
        }

        private bool validarapellido() //VALIDAR APELLIDO DEL CLIENTE
        {
            if (string.IsNullOrEmpty(txtapellido.Text))
            {
                erpError.SetError(txtapellido, "Debe ingresar un apellido valido");
                return false;
            }
            else
            {
                erpError.SetError(txtapellido, "");
                return true;
            }
        }

        private bool validarnombre() //VALIDAR NOMBRE DEL CLIENTE
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                erpError.SetError(txtnombre, "Debe ingresar un nombre valido");
                return false;
            }
            else
            {
                erpError.SetError(txtnombre, "");
                return true;
            }
        }

        private bool validaridcliente()  //VALIDAR ID DEL CLIENTE
        {
            int id;
            if (!int.TryParse(txtidcliente.Text, out id) || txtidcliente.Text == "")
            {
                erpError.SetError(txtidcliente, "Debe ingresar id valido");
                txtidcliente.Clear();
                txtidcliente.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtidcliente, "");
                return true;
            }
        }
        private void mostarDatos()
        {
            DataTable consulta = ClienteDB.mostrar(); //NOMBRE DE LA BASE DE DATOS CLIENTEDB
            if (consulta == null)
            {
                MessageBox.Show("No se pudo acceder a los datos");
            }

            else
            {
                listadatos.DataSource = consulta.DefaultView;
            }
        }

        private void REGISTRAR_Load(object sender, EventArgs e)
        {
            mostarDatos();
        }

        private void regresarbtn_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void registrarbtn_Click_1(object sender, EventArgs e)
        {
            if (validaridcliente() == false)
            {
                return;
            }
            if (validarnombre() == false)
            {
                return;
            }
            if (validarapellido() == false)
            {
                return;
            }
            if (validartelefono() == false)
            {
                return;
            }
            if (validaremail() == false)
            {
                return;
            }
            if (validardireccion() == false)
            {
                return;
            }
            try
            {
                ClaseCliente cl = new ClaseCliente();

                cl.IdCliente = txtidcliente.Text;
                cl.Nombre = txtnombre.Text;
                cl.Apellido = txtapellido.Text;
                cl.Telefono = txttelefono.Text;
                cl.Email = txtemail.Text;
                cl.Direccion = txtdireccion.Text;

                if (ClienteDB.guardar(cl))
                {
                    mostarDatos();
                    MessageBox.Show("REGISTRO COMPLETADO");

                }
                else
                {

                    MessageBox.Show("EL CLIENTE YA ESTA REGISTRADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtidcliente.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txttelefono.Text = "";
            txtemail.Text = "";
            txtdireccion.Text = "";
            txtidcliente.Focus();
        }
    }
}
