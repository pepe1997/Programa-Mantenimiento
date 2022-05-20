using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReponedorCliente.formularios;

namespace ReponedorCliente.formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btmFrmCliente_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.Show();
        }

        private void mantenedorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente c = new FrmCliente();
            c.Show();
        }
    }
}
