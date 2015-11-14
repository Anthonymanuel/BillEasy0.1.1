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
    public partial class Login : Form
    {
        ErrorProvider miError;
        public Login()
        {
            InitializeComponent();
            miError = new ErrorProvider();
        }

        public void Limpiar()
        {
            UsuariotextBox.Clear();
            ContrasenatextBox.Clear();
        }

        private void Accederbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            usuarios.NombreUsuario = UsuariotextBox.Text;
            usuarios.Contrasena = ContrasenatextBox.Text;

            if (UsuariotextBox.TextLength == 0 || ContrasenatextBox.TextLength == 0)
            {
                miError.Clear();
                miError.SetError(UsuariotextBox, "Debe llenar este Campo");
            }
            else
            {
                if (usuarios.VerificarUsuario() == UsuariotextBox.Text && usuarios.VerificarContrasena() == ContrasenatextBox.Text)
                {
                    
                    this.Visible = false;
                    this.Hide();
                    BillEasy billEasy = new BillEasy();
                    billEasy.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nombre de Usuario o Contraseña Incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
