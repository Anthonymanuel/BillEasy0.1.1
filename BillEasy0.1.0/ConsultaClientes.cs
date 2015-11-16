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
    public partial class ConsultaClientes : Form
    {

        ErrorProvider miError;
        public ConsultaClientes()
        {
            miError = new ErrorProvider();
            InitializeComponent();
            BuscarClientescomboBox.SelectedIndex = 0;
        }

        public int Error()
        {
            int contador = 0;
            if (ClientestextBox.TextLength == 0)
            {
                miError.SetError(ClientestextBox, "Debe Completar el campo");
                contador = 1;
            }
            else
            {
                miError.SetError(ClientestextBox, "");
            }
            return contador;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            DataTable dt = new DataTable();
            string condicion;

            if (Error() == 0)
            {
                if (BuscarClientescomboBox.SelectedIndex == 0)
                {
                    if (ClientestextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        int id;
                        int.TryParse(ClientestextBox.Text, out id);
                        condicion = "ClienteId =" + id.ToString();
                    }
                    dt = clientes.Listado("ClienteId,Nombres,Apellidos,c.Nombre as Ciudad,Telefono,Celular,Email,Cedula", condicion, "");
                    ClientesdataGridView.DataSource = dt;
                }
                if (BuscarClientescomboBox.SelectedIndex == 1)
                {
                    if (ClientestextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = string.Format("Nombres = '{0}' ", ClientestextBox.Text);
                    }
                    dt = clientes.Listado("ClienteId,Nombres,Apellidos,c.Nombre as Ciudad,Telefono,Celular,Email,Cedula", condicion, "");
                    ClientesdataGridView.DataSource = dt;
                }
                if (BuscarClientescomboBox.SelectedIndex == 2)
                {
                    if (ClientestextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = string.Format("Apellidos = '{0}' ", ClientestextBox.Text);
                    }
                    dt = clientes.Listado("ClienteId,Nombres,Apellidos,c.Nombre as Ciudad,Telefono,Celular,Email,Cedula", condicion, "");
                    ClientesdataGridView.DataSource = dt;
                }
                if (BuscarClientescomboBox.SelectedIndex == 3)
                {
                    if (ClientestextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = string.Format("Telefono = '{0}' ", ClientestextBox.Text);
                    }
                    dt = clientes.Listado("ClienteId,Nombres,Apellidos,c.Nombre as Ciudad,Telefono,Celular,Email,Cedula", condicion, "");
                    ClientesdataGridView.DataSource = dt;
                }
                if (BuscarClientescomboBox.SelectedIndex == 4)
                {
                    if (ClientestextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = string.Format("Celular = '{0}' ", ClientestextBox.Text);
                    }
                    dt = clientes.Listado("ClienteId,Nombres,Apellidos,c.Nombre as Ciudad,Telefono,Celular,Email,Cedula", condicion, "");
                    ClientesdataGridView.DataSource = dt;
                }
                if (BuscarClientescomboBox.SelectedIndex == 5)
                {
                    if (ClientestextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = string.Format("Email = '{0}' ", ClientestextBox.Text);
                    }
                    dt = clientes.Listado("ClienteId,Nombres,Apellidos,c.Nombre as Ciudad,Telefono,Celular,Email,Cedula", condicion, "");
                    ClientesdataGridView.DataSource = dt;
                }
                if (BuscarClientescomboBox.SelectedIndex == 6)
                {
                    if (ClientestextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = string.Format("Cedula = '{0}' ", ClientestextBox.Text);
                    }
                    dt = clientes.Listado("ClienteId,Nombres,Apellidos,c.Nombre as Ciudad,Telefono,Celular,Email,Cedula", condicion, "");
                    ClientesdataGridView.DataSource = dt;
                }
            }
        }
        
    }
}
