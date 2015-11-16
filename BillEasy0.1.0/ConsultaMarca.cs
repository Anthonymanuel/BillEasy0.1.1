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
    public partial class ConsultaMarca : Form
    {
        ErrorProvider miError;
        public ConsultaMarca()
        {
            InitializeComponent();
            miError = new ErrorProvider();
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
            Marcas marca = new Marcas();
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
                        condicion = "MarcaId = " + id.ToString();
                    }
                    dataTable = marca.Listado(" MarcaId, Nombre", condicion, "");
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
                dataTable = marca.Listado(" MarcaId, Nombre ", condicion, "");
                DatosdataGridView.DataSource = dataTable;

            }
        }
    }
}
