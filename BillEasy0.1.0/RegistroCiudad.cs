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
using System.Text.RegularExpressions;
namespace BillEasy0._1._0
{
    public partial class RegistroCiudad : Form
    {
        ErrorProvider miError;
        public RegistroCiudad()
        {
            InitializeComponent();
            miError = new ErrorProvider();
        }

        private void LlenarDatos(Ciudades ciudad)
        {
            ciudad.Nombre = NombreTextBox.Text;
            int codigoPostal;
            int.TryParse(CodigoPostalTextBox.Text, out codigoPostal);
            ciudad.CodigoPostal = codigoPostal;
        }

        private int Error()
        {
            int contador = 0;

            if (NombreTextBox.Text == "")
            {
                miError.SetError(NombreTextBox, "Debe llenar el nombre de la ciudad");
                contador = 1;
            }
            else
            {
                miError.SetError(NombreTextBox, "");
            }
            if (CodigoPostalTextBox.Text == "")
            {
                miError.SetError(CodigoPostalTextBox, "Debe llenar el codigo postal");
                contador = 1;
            }
            else
            {
                miError.SetError(CodigoPostalTextBox, "");
            } 
            return contador;
        }



        private int Validar()
        {
            int retorno = 0;
            
                if (!Regex.Match(CodigoPostalTextBox.Text, @"^\d{5}$").Success)
                {
                    MessageBox.Show("Codigo postal invalido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CodigoPostalTextBox.Focus();
                }
                else
                {
                    Regex espacio = new Regex(@"\s+");
                    NombreTextBox.Text = espacio.Replace(NombreTextBox.Text, " ");
                    retorno += 1;
                }
            
            return retorno;
        }
        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            int id;
            int.TryParse(CiudadIdTextBox.Text, out id);
            ciudad.Buscar(id);
            CiudadIdTextBox.Text = ciudad.CiudadId.ToString();
            NombreTextBox.Text = ciudad.Nombre;
            CodigoPostalTextBox.Text = ciudad.CodigoPostal.ToString();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            CiudadIdTextBox.Clear();
            NombreTextBox.Clear();
            CodigoPostalTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            if (CiudadIdTextBox.Text.Length > 0 && Error() == 0 && Validar() == 1)
            {

                int id;
                int.TryParse(CiudadIdTextBox.Text, out id);
                ciudad.CiudadId = id;
                LlenarDatos(ciudad);
                if (ciudad.Editar() && Validar() == 1 && Error() == 0)
                {
                    MessageBox.Show("Ciudad Editada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Debe de completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (CiudadIdTextBox.Text.Length == 0 && Error() == 0 && Validar() == 1)
            {
                LlenarDatos(ciudad);
                if (ciudad.Insertar())
                {
                    MessageBox.Show("Ciudad Guardada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al insertar la ciudad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Ciudades ciudad = new Ciudades();
            int id;
            if (CiudadIdTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe especificar el ID", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (CiudadIdTextBox.Text.Length > 0)
            {
                int.TryParse(CiudadIdTextBox.Text, out id);
                ciudad.CiudadId = id;
                if (ciudad.Eliminar())
                {
                    MessageBox.Show("Ciudad Eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la ciudad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
