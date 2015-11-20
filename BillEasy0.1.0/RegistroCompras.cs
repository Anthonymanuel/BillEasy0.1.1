using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace BillEasy0._1._0
{
    public partial class RegistroCompras : Form
    {
        public RegistroCompras()
        {
            InitializeComponent();
        }
        private void RegistroCompras_Load(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            Usuarios usuario = new Usuarios();
            ClienteComboBox.DataSource = cliente.Listado("*", "1=1", "");
            ClienteComboBox.DisplayMember = "Nombres";
            ClienteComboBox.ValueMember = "ClienteId";
        }
        private void BuscarVentaButton_Click(object sender, EventArgs e)
        {

        }

        private void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            int productoId;
            int.TryParse(ProductoIdTextBox.Text,out productoId);
            if (producto.Buscar(productoId))
            {
                NombreTextBox.Text = producto.Nombre;
                CostoTextBox.Text = producto.Costo.ToString();
                ITBISTextBox.Text = producto.ITBIS.ToString();
            }
            else
            {
                MessageBox.Show("El producto no existe", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            CompraDataGridView.Rows.Add(ProductoIdTextBox.Text, NombreTextBox.Text, CantidadTextBox.Text, CostoTextBox.Text, ITBISTextBox.Text, DescuentosTextBox.Text);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CompraIdTextBox.Clear();
            ProductoIdTextBox.Clear();
            CantidadTextBox.Clear();
            CostoTextBox.Clear();
            NFCTextBox.Clear();
            TipoNFCTextBox.Clear();
            TipoCompraTextBox.Clear();
            DescuentosTextBox.Clear();
            TotallTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Compras compra = new Compras();
            if (compra.Eliminar())
            {
                MessageBox.Show("Compra Eliminada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NuevoButton.PerformClick();
            }
            else
            {
                MessageBox.Show("Error al eliminar", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
