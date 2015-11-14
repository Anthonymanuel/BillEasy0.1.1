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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ClienteIdtextBox.Clear();
            NombrestextBox.Clear();
            ApellidostextBox.Clear();
            TelefonomaskedTextBox.Clear();
            CelularmaskedTextBox.Clear();
            DirecciontextBox.Clear();
            EmailtextBox.Clear();
            CedulamaskedTextBox.Clear();
        }
        public void Datos(Clientes clientes)
        {
            
            int id;
            int.TryParse(ClienteIdtextBox.Text, out id);
            clientes.ClienteId = id;
            clientes.CiudadId = (int)CiudadcomboBox.SelectedValue;
            clientes.Nombres = NombrestextBox.Text;
            clientes.Apellidos = ApellidostextBox.Text;
            clientes.Telefono = TelefonomaskedTextBox.Text;
            clientes.Celular = CelularmaskedTextBox.Text;
            clientes.Direccion = DirecciontextBox.Text;
            clientes.Email = EmailtextBox.Text;
            clientes.Cedula = CedulamaskedTextBox.Text;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            if(ClienteIdtextBox.TextLength == 0)
            {
                Datos(clientes);
                if (clientes.Insertar())
                {
                    MessageBox.Show("Cliente insertado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error tratndo de insertar el cliente","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                Nuevobutton.PerformClick();            }
            else
            {
                Datos(clientes);
                if (clientes.Editar())
                {
                    MessageBox.Show("Se edito Correctamente","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al editar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Nuevobutton.PerformClick();
            }
        }
        public int ConversionId()
        {
            int id;
            int.TryParse(ClienteIdtextBox.Text,out id);

            return id;
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            Ciudades ciudad = new Ciudades();
     
            if (clientes.Buscar(ConversionId()))
            {
                NombrestextBox.Text = clientes.Nombres;
                ApellidostextBox.Text = clientes.Apellidos;
                TelefonomaskedTextBox.Text = clientes.Telefono;
                CelularmaskedTextBox.Text = clientes.Celular;
                DirecciontextBox.Text = clientes.Direccion;
                EmailtextBox.Text = clientes.Email;
                CedulamaskedTextBox.Text = clientes.Cedula;
                
            }
            else
            {
                MessageBox.Show("El id especificado no existe","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.ClienteId = ConversionId();
            if (clientes.Eliminar() == true)
            {
                MessageBox.Show("Cliente eliminado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ese cliente no existe","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            Ciudades ciudades = new Ciudades();
            CiudadcomboBox.DataSource = ciudades.Listado("CiudadId,Nombre,CodigoPostal ","1=1","");
            CiudadcomboBox.DisplayMember = string.Format("Nombre");
            CiudadcomboBox.ValueMember = "CiudadId";
        }

        
    }
}
