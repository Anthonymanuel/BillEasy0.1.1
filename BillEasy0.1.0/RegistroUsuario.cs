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
    public partial class RegistroUsuario : Form
    {
        ErrorProvider miError;
        public RegistroUsuario()
        {
            InitializeComponent();
            FechamaskedTextBox.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now);
            miError = new ErrorProvider();
        }

        private void LlenarDatos(Usuarios usuarios)
        {
            usuarios.Nombre = NombreTextBox.Text;
            usuarios.NombreUsuario = NombreUsuarioTextBox.Text;
            usuarios.Contrasena = ContrasenaTextBox.Text;
            usuarios.Area = AreaTextBox.Text;
            usuarios.Fecha = FechamaskedTextBox.Text;
        }

        private int Error()
        {
            int contador = 0;

            if (NombreTextBox.Text == "")
            {
                miError.SetError(NombreTextBox, "Debe llenar el nombre del empleado");
                contador = 1;
            }
            else
            {
                miError.SetError(NombreTextBox, "");
            }
            if (NombreUsuarioTextBox.Text == "")
            {
                miError.SetError(NombreUsuarioTextBox, "Debe llenar el nombre de usuario");
                contador = 1;
            }
            else
            {
                miError.SetError(NombreUsuarioTextBox, "");
            }
            if (ContrasenaTextBox.Text == "")
            {
                miError.SetError(ContrasenaTextBox, "Debe llenar la contraseña");
                contador = 1;
            }
            else
            {
                miError.SetError(ContrasenaTextBox, "");
            }
            if (AreaTextBox.Text == "")
            {
                miError.SetError(AreaTextBox, "Debe llenar el nombre de usuario");
                contador = 1;
            }
            else
            {
                miError.SetError(AreaTextBox, "");
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
                else
                {
                    retorno += 1;
                    Regex espacio = new Regex(@"\s+");
                    NombreTextBox.Text = espacio.Replace(NombreTextBox.Text, " ");
                    AreaTextBox.Text = espacio.Replace(AreaTextBox.Text, " ");

                }
            return retorno;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Usuarios usuario = new Usuarios();

            int.TryParse(UsuarioIdTextBox.Text, out id);
            usuario.UsuarioId = id;
            usuario.Buscar(id);
            NombreTextBox.Text = usuario.Nombre;
            NombreUsuarioTextBox.Text = usuario.NombreUsuario;
            ContrasenaTextBox.Text = usuario.Contrasena;
            AreaTextBox.Text = usuario.Area;
            FechamaskedTextBox.Text = usuario.Fecha;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            UsuarioIdTextBox.Clear();
            NombreTextBox.Clear();
            NombreUsuarioTextBox.Clear();
            ContrasenaTextBox.Clear();
            AreaTextBox.Clear();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            if (UsuarioIdTextBox.Text.Length > 0 && Error() == 0 && Validar() == 1)
            {
                int id;
                int.TryParse(UsuarioIdTextBox.Text, out id);
                usuarios.UsuarioId = id;
                LlenarDatos(usuarios);
                if (usuarios.Editar())
                {
                    MessageBox.Show("Usuario editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Debe de completar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (UsuarioIdTextBox.Text.Length == 0 && Error() == 0  && Validar() == 1)
            {

                LlenarDatos(usuarios);
                if (usuarios.Insertar())
                {
                    MessageBox.Show("Usuario guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Error al insertar el usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            if (UsuarioIdTextBox.TextLength == 0)
            {
                MessageBox.Show("Debe especificar el ID", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (UsuarioIdTextBox.Text.Length > 0)
                {
                    int id;
                    int.TryParse(UsuarioIdTextBox.Text, out id);
                    usuario.UsuarioId = id;

                    if (usuario.Eliminar())
                    {
                        MessageBox.Show("Usuario Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NuevoButton.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void UsuarioIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }
    }
}
