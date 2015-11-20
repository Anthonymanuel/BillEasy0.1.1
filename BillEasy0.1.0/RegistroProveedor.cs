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
        ErrorProvider miError;
        public RegistroProveedor()
        {
            InitializeComponent();
            miError = new ErrorProvider();
        }

        private void LlenarDatos(Proveedores proveedor)
        {
            proveedor.CiudadId = (int)CiudadComboBox.SelectedValue;
            proveedor.NombreEmpresa = NombreEmpresaTextBox.Text;
            proveedor.Direccion = DireccionTextBox.Text;
            proveedor.Telefono = TelefonoTextBox.Text;
            proveedor.Email = EmailTextBox.Text;
            proveedor.RNC = RNCTextBox.Text;
            proveedor.NombreRepresentante = NombreRepresentanteTextBox.Text;
            proveedor.Celular = CelularTextBox.Text;
        }

        private int Error()
        {
            int contador = 0;

            if (NombreEmpresaTextBox.Text == "")
            {
                miError.SetError(NombreEmpresaTextBox, "Debe llenar el nombre de la empresa");
                contador = 1;
            }
            else
            {
                miError.SetError(NombreEmpresaTextBox, "");
            }
            if (DireccionTextBox.Text == "")
            {
                miError.SetError(DireccionTextBox, "Debe llenar la direccion");
                contador = 1;
            }
            else
            {
                miError.SetError(DireccionTextBox, "");
            }
            if (TelefonoTextBox.Text == "")
            {
                miError.SetError(TelefonoTextBox, "Debe llenar el numero de telefono");
                contador = 1;
            }
            else
            {
                miError.SetError(TelefonoTextBox, "");
            }
            if (EmailTextBox.Text == "")
            {
                miError.SetError(EmailTextBox, "Debe llenar el email");
                contador = 1;
            }
            else
            {
                miError.SetError(EmailTextBox, "");
            }
            if (RNCTextBox.Text == "")
            {
                miError.SetError(RNCTextBox, "Debe llenar el RNC");
                contador = 1;
            }
            else
            {
                miError.SetError(RNCTextBox, "");
            }
            if (NombreRepresentanteTextBox.Text == "")
            {
                miError.SetError(NombreRepresentanteTextBox, "Debe llenar el  nombre del representante");
                contador = 1;
            }
            else
            {
                miError.SetError(NombreRepresentanteTextBox, "");
            }
            if (CelularTextBox.Text == "")
            {
                miError.SetError(CelularTextBox, "Debe llenar el  numero de telefono");
                contador = 1;
            }
            else
            {
                miError.SetError(CelularTextBox, "");
            }
            return contador;
        }

        public int Convertidor()
        {
            int id;
            int.TryParse(ProveedorIdTextBox.Text, out id);
            return id;
        }

        private void RegistroProveedor_Load_1(object sender, EventArgs e)
        {

            Ciudades ciudad = new Ciudades();
            CiudadComboBox.DataSource = ciudad.Listado("CiudadId,Nombre,CodigoPostal ", "1=1", "");
            CiudadComboBox.DisplayMember = "Nombre";
            CiudadComboBox.ValueMember = "CiudadId";
        }

        private void BuscarButton_Click(object sender, EventArgs e)
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

        private void NuevoButton_Click(object sender, EventArgs e)
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
       
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
           
            if(ProveedorIdTextBox.TextLength == 0)
            {
                LlenarDatos(proveedor);
                if (proveedor.Insertar() && Error() == 0)
                {
                    MessageBox.Show("Proveedor insertado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al insertar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                proveedor.ProveedorId = Convertidor();
                LlenarDatos(proveedor);
                if (proveedor.Editar())
                {
                    MessageBox.Show("Proveedor editado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Erro al editar","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            

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
                NuevoButton.PerformClick();
            }
            else
            {
                MessageBox.Show("Error al eliminar el proveedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
