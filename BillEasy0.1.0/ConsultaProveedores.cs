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
    public partial class ConsultaProveedores : Form
    {
        ErrorProvider miError;
        public ConsultaProveedores()
        {
            miError = new ErrorProvider();
            InitializeComponent();
            BuscarcomboBox.SelectedIndex = 0;
        }

        public int Error()
        {
            int contador = 0;
            if (DatostextBox.TextLength == 0)
            {
                miError.SetError(DatostextBox, "Debe Completar el campo");
                contador = 1;
            }
            else
            {
                miError.SetError(DatostextBox, "");
            }
            return contador;
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Proveedores proveedor = new Proveedores();
            DataTable dataTable = new DataTable();
            string condicion;
            if (Error() == 0)
            {
                if (BuscarcomboBox.SelectedIndex == 0)
                {
                    if (DatostextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        int id;
                        int.TryParse(DatostextBox.Text, out id);
                        condicion = "ProveedorId = " + id.ToString();
                    }
                    dataTable = proveedor.Listado(" ProveedorId,CiudadId,NombreEmpresa,Direccion,Telefono,Email,RNC,NombreRepresentante,Celular ", condicion, "");
                    DatosdataGridView.DataSource = dataTable;
                }
            }
            if (BuscarcomboBox.SelectedIndex == 1)
            {
                if (DatostextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2";
                }
                else
                {
                    condicion = string.Format("NombreEmpresa = '{0}' ", DatostextBox.Text);
                }
                dataTable = proveedor.Listado(" ProveedorId,CiudadId,NombreEmpresa,Direccion,Telefono,Email,RNC,NombreRepresentante,Celular ", condicion, "");
                DatosdataGridView.DataSource = dataTable;

            }
            if (BuscarcomboBox.SelectedIndex == 2)
            {
                if (DatostextBox.Text.Trim().Length == 2)
                {
                    condicion = "3=3";
                }
                else
                {
                    condicion = string.Format("RNC= '{0}'", DatostextBox.Text);

                    dataTable = proveedor.Listado(" ProveedorId,CiudadId,NombreEmpresa,Direccion,Telefono,Email,RNC,NombreRepresentante,Celular ", condicion, "");
                    DatosdataGridView.DataSource = dataTable;
                }
                if (BuscarcomboBox.SelectedIndex == 3)
                {
                    if (DatostextBox.Text.Trim().Length == 3)
                    {
                        condicion = "4=4";
                    }
                    else
                    {
                        condicion = string.Format("NombreRepresentante = '{0}'", DatostextBox.Text);
                    }
                    dataTable = proveedor.Listado(" ProveedorId,CiudadId,NombreEmpresa,Direccion,Telefono,Email,RNC,NombreRepresentante,Celular ", condicion, "");
                    DatosdataGridView.DataSource = dataTable;
                }
            }
        }
    }
}
