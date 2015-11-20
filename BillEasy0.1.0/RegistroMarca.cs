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
    public partial class RegistroMarca : Form
    {
        ErrorProvider miError;
        public RegistroMarca()
        {
            InitializeComponent();
            miError = new ErrorProvider();
        }

        private void LlenarDatos(Marcas marca)
        {
            marca.Nombre = NombreTextBox.Text;
        }

        private int Error()
        {
            int contador = 0;
            if (NombreTextBox.Text == "")
            {
                miError.SetError(NombreTextBox, "Debe llenar el nombre de la marca");
                contador += 1;
            }
            else
            {
                miError.SetError(NombreTextBox, "");
            }
            return contador;
        }

        private int Validar()
        {
            int retorno = 0;

            Regex espacio = new Regex(@"\s+");
            NombreTextBox.Text = espacio.Replace(NombreTextBox.Text, " ");
            retorno += 1;
            return retorno;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            int id;
            int.TryParse(MarcaIdTextBox.Text, out id);
            marca.Buscar(id);
            NombreTextBox.Text = marca.Nombre;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            MarcaIdTextBox.Clear();
            NombreTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            if (MarcaIdTextBox.Text.Length > 0 && Validar() == 1 && Error() == 0)
            {
                int id;
                int.TryParse(MarcaIdTextBox.Text, out id);
                marca.MarcaId = id;
                LlenarDatos(marca);
                Validar();
                if (marca.Editar() && Error() == 0 && Validar() == 1 )
                {
                    MessageBox.Show("Marca Editada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al insertar la marca ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (MarcaIdTextBox.Text.Length == 0 && Error() == 0 && Validar() == 1 )
            {
                LlenarDatos(marca);
                Error();
                Validar();
                if (marca.Insertar())
                {
                    MessageBox.Show("Marca Guardada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al insertar la marca ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Marcas marca = new Marcas();
            int id;
            if (MarcaIdTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe especificar el ID", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (MarcaIdTextBox.Text.Length > 0)
            {
                int.TryParse(MarcaIdTextBox.Text, out id);
                marca.MarcaId = id;
                if (marca.Eliminar())
                {
                    MessageBox.Show("Marca Eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la marca", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
