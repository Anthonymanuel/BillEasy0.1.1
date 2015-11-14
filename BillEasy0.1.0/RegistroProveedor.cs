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
    public partial class RegistroProveedor : Form
    {
        public RegistroProveedor()
        {
            InitializeComponent();
        }

        private void LlenarDatos(Proveedores proveedor)
        {
            //proveedor.CiudadId = Convert.ToInt32(CiudadComboBox.ValueMember);
            proveedor.NombreEmpresa = NombreEmpresaTextBox.Text;
            proveedor.Direccion = DireccionTextBox.Text;
            proveedor.Telefono = TelefonoTextBox.Text;
            proveedor.Email = EmailTextBox.Text;
            proveedor.RNC = RNCTextBox.Text;
            proveedor.NombreRepresentante = NombreRepresentanteTextBox.Text;
            proveedor.Celular = CelularTextBox.Text;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            int id;
            int.TryParse(ProveedorIdTextBox.Text, out id);
            proveedor.Buscar(id);
            ProveedorIdTextBox.Text = proveedor.ProveedorId.ToString();
            NombreEmpresaTextBox.Text = proveedor.NombreEmpresa;
            DireccionTextBox.Text = proveedor.Direccion;
            TelefonoTextBox.Text = proveedor.Telefono;
            EmailTextBox.Text = proveedor.Email;
            RNCTextBox.Text = proveedor.RNC;
            NombreRepresentanteTextBox.Text = proveedor.NombreRepresentante;
            CelularTextBox.Text = proveedor.Celular;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ProveedorIdTextBox.Clear();
            NombreEmpresaTextBox.Clear();
            DireccionTextBox.Clear();
            TelefonoTextBox.Clear();
            EmailTextBox.Clear();
            RNCTextBox.Clear();
            NombreRepresentanteTextBox.Clear();
            CelularTextBox.Clear();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            LlenarDatos(proveedor);
            proveedor.Insertar();

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            if (ProveedorIdTextBox.TextLength > 0)
            {
                int id;
                int.TryParse(ProveedorIdTextBox.Text, out id);
                proveedor.ProveedorId = id;
                if (proveedor.Eliminar())
                    MessageBox.Show("Proveedor Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevobutton.PerformClick();
            }
            else
            {
                MessageBox.Show("Error al eliminar el proveedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistroProveedor_Load(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            CiudadComboBox.DataSource = ciudad.Listado("CiudadId,Nombre,CodigoPostal", "1=1", "");
            CiudadComboBox.DisplayMember = string.Format("Nombre");
            CiudadComboBox.ValueMember = "CiudadId";
        }
    }
}
