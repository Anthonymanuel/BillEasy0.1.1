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
    public partial class RegistroVentas : Form
    {
        public RegistroVentas()
        {
            InitializeComponent();
        }


        private void RegistroVentas_Load(object sender, EventArgs e)
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
            int productoId;
            int.TryParse(ProductoIdTextBox.Text, out productoId);
            Productos producto = new Productos();


            if (producto.Buscar(productoId))
            {
               // MessageBox.Show("Producto encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PrecioTextBox.Text = producto.Precio.ToString();
                NombreTextBox.Text = producto.Nombre;
                ITBISTextBox.Text = producto.Costo.ToString();
               /* foreach (DataGridViewRow row in VentasDataGridView.Rows)
                {

                    codigo += Convert.ToString(row.Cells["ProductoId"].Value);

                }*/

            }
            else
            {
                MessageBox.Show("El producto no existe", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarButton_Click_1(object sender, EventArgs e)
        {
            VentasDataGridView.Rows.Add(ProductoIdTextBox.Text,NombreTextBox.Text, CantidadTextBox.Text, PrecioTextBox.Text,ITBISTextBox.Text, DescuentosTextBox.Text);
        }
           
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            VentaIdTextBox.Clear();
            ProductoIdTextBox.Clear();
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
            NFCTextBox.Clear();
            TipoNFCTextBox.Clear();
            TipoVentasTextBox.Clear();
            DescuentosTextBox.Clear();
            TotallTextBox.Clear();
        }
        public int Convertir()
        {
            int id;
            int.TryParse(VentaIdTextBox.Text,out id);
            return id;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.Insertar();
        }
        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.VentaId = Convertir();

            if (ventas.Eliminar())
            {
                MessageBox.Show("Venta Eliminada","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                NuevoButton.PerformClick();
            }
            else
            {
                MessageBox.Show("Error al eliminar","alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
