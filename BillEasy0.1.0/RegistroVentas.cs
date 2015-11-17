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

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            VentaIdtextBox.Clear();
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
            NFCtextBox.Clear();
            TipoNFCtextBox.Clear();
            TipoVentastextBox.Clear();
            DescuentostextBox.Clear();
            TotaltextBox.Clear();
        }
    }
}
