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
    public partial class ConsultaCiudad : Form
    {
        ErrorProvider miError;
        public ConsultaCiudad()
        {
            InitializeComponent();
            miError = new ErrorProvider();
            BuscarcomboBox.SelectedIndex = 0;
        }

        public void Error()
        {
            miError.SetError(DatostextBox, "Debe Completar el campo");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            DataTable dataTable = new DataTable();
            string condicion;

            if (DatostextBox.TextLength == 0)
            {
                Error();
            }
            else
            {
                if (BuscarcomboBox.SelectedIndex == 0)
                {
                    if (DatostextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = "CiudadId = " + DatostextBox.Text;
                    }
                    dataTable = ciudad.Listado(" CiudadId, Nombre, CodigoPostal ", condicion, "");
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
                    condicion = string.Format("Nombre = '{0}' ", DatostextBox.Text);
                }
                dataTable = ciudad.Listado(" CiudadId, Nombre, CodigoPostal ", condicion, "");
                DatosdataGridView.DataSource = dataTable;

            }
            if (BuscarcomboBox.SelectedIndex == 2)
            {
                if (DatostextBox.Text.Trim().Length == 1)
                {
                    condicion = "3=3";
                }
                else
                {
                    condicion = "CodigoPostal = " + DatostextBox.Text;
                }
                dataTable = ciudad.Listado(" CiudadId, Nombre, CodigoPostal ", condicion, "");
                DatosdataGridView.DataSource = dataTable;

            }
        }
        }
}
