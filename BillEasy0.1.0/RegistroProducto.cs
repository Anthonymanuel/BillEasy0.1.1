using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
namespace BillEasy0._1._0
{
    public partial class RegistroProducto : Form
    {
        ErrorProvider miError;
        public RegistroProducto()
        {
            InitializeComponent();
            miError = new ErrorProvider();
        }
        private void LLenarDatos(Productos producto)
        {
            float precio, costo, itbis;
            int cantidad;
            float.TryParse(PrecioTextBox.Text, out precio);
            float.TryParse(CostoTextBox.Text, out costo);
            float.TryParse(ITBISTextBox.Text, out itbis);
            int.TryParse(CantidadTextBox.Text, out cantidad);
            producto.ProveedorId = (int)ProveedorComboBox.SelectedValue;
            producto.MarcaId = (int)MarcaComboBox.SelectedValue;
            producto.Nombre = NombreTextBox.Text;
            producto.Cantidad = cantidad;
            producto.Precio = precio;
            producto.Costo = costo;
            producto.ITBIS = itbis;
        }
        private int Error()
        {
            int contador = 0;

            if (NombreTextBox.Text == "")
            {
                miError.SetError(NombreTextBox, "Debe llenar el nombre del producto");
                contador = 1;
            }
            else
            {
                miError.SetError(NombreTextBox, "");
            }
            if (CantidadTextBox.Text == "")
            {
                miError.SetError(CantidadTextBox, "Debe llenar la cantidad");
                contador = 1;
            }
            else
            {
                miError.SetError(CantidadTextBox, "");
            }
            if (PrecioTextBox.Text == "")
            {
                miError.SetError(PrecioTextBox, "Debe llenar el precio");
                contador = 1;
            }
            else
            {
                miError.SetError(PrecioTextBox, "");
            }
            if (CostoTextBox.Text == "")
            {
                miError.SetError(CostoTextBox, "Debe llenar el Costo");
                contador = 1;
            }
            else
            {
                miError.SetError(CostoTextBox, "");
            }
            if (ITBISTextBox.Text == "")
            {
                miError.SetError(ITBISTextBox, "Debe llenar el ITBIS");
                contador = 1;
            }
            else
            {
                miError.SetError(ITBISTextBox, "");
            }
            return contador;
        }
        private int Validar()
        {
            int retorno = 0;
            if (!Regex.Match(NombreTextBox.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Nombre  invalido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            if (!Regex.Match(CantidadTextBox.Text, @"(\d+( \.)?\d*)").Success)
            {
                MessageBox.Show("la cantidad debe de ser entera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            if (!Regex.Match(PrecioTextBox.Text, @"(\d+( \.)?\d*)").Success)
            {
                MessageBox.Show("El precio debe ser numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            if (!Regex.Match(CostoTextBox.Text, @"(\d+( \.)?\d*)").Success)
            {
                MessageBox.Show("Costo debe ser numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            if (!Regex.Match(ITBISTextBox.Text, @"(\d+( \.)?\d*)").Success)
            {
                MessageBox.Show("ITBIS debe ser numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            else
            {
                Regex espacio = new Regex(@"\s+");
                NombreTextBox.Text = espacio.Replace(NombreTextBox.Text, " ");
                retorno += 1;
            }

            return retorno;
        }

        public int Convertidor()
        {
            int id;
            int.TryParse(ProductoIdTextBox.Text, out id);
            return id;
        }

        private void RegistroProducto_Load(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            Marcas marca = new Marcas();
            ProveedorComboBox.DataSource = proveedor.Listado("ProveedorId ,CiudadId, NombreEmpresa,Direccion,Telefono,Email,RNC,NombreRepresentante,Celular", "1=1", "");
            ProveedorComboBox.DisplayMember = "NombreEmpresa";
            ProveedorComboBox.ValueMember = "ProveedorId";

            MarcaComboBox.DataSource = marca.Listado("MarcaId,Nombre", "1=1", "");
            MarcaComboBox.DisplayMember = "Nombre";
            MarcaComboBox.ValueMember = "MarcaId";

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            int id;
            int.TryParse(ProductoIdTextBox.Text, out id);
            producto.Buscar(id);
            ProductoIdTextBox.Text = producto.ProductoId.ToString();
            NombreTextBox.Text = producto.Nombre.ToString();
            CantidadTextBox.Text = producto.Cantidad.ToString();
            PrecioTextBox.Text = producto.Precio.ToString();
            CostoTextBox.Text = producto.Costo.ToString();
            ITBISTextBox.Text = producto.ITBIS.ToString();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            ProductoIdTextBox.Clear();
            NombreTextBox.Clear();
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
            CostoTextBox.Clear();
            ITBISTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            if(ProductoIdTextBox.TextLength == 0)
            {
                LLenarDatos(productos);
                if (productos.Insertar() && Error() == 0)
                {
                    MessageBox.Show("Producto insertado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error la insertar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                LLenarDatos(productos);
                productos.ProductoId = Convertidor();
                if(productos.Editar())
                {
                    MessageBox.Show("Producto editado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al editar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            if (ProductoIdTextBox.TextLength > 0)
            {
                int id;
                int.TryParse(ProductoIdTextBox.Text, out id);
                producto.ProveedorId = id;
                if (producto.Eliminar())
                    MessageBox.Show("Producto Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NuevoButton.PerformClick();
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
