using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillEasy0._1._0
{
    public partial class BillEasy : Form
    {
        public BillEasy()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();
            registro.MdiParent = this;
            registro.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuario consultaUsuario = new ConsultaUsuario();
            consultaUsuario.MdiParent = this;
            consultaUsuario.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroMarca registro = new RegistroMarca();
            registro.MdiParent = this;
            registro.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaMarca consultaMarca = new ConsultaMarca();
            consultaMarca.MdiParent = this;
            consultaMarca.Show();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCiudad ciudad = new RegistroCiudad();
            ciudad.MdiParent = this;
            ciudad.Show();
        }

        private void ciudadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCiudad consultaCiudad = new ConsultaCiudad();
            consultaCiudad.MdiParent = this;
            consultaCiudad.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroClientes clientes = new RegistroClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientes consultaClientes = new ConsultaClientes();
            consultaClientes.MdiParent = this;
            consultaClientes.Show();
        }

        private void BillEasy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto producto = new RegistroProducto();
            producto.MdiParent = this;
            producto.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProducto producto = new ConsultaProducto();
            producto.MdiParent = this;
            producto.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProveedor proveedor = new RegistroProveedor();
            proveedor.MdiParent = this;
            proveedor.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaProveedores proveedor = new ConsultaProveedores();
            proveedor.MdiParent = this;
            proveedor.Show();
        }
    }
}
