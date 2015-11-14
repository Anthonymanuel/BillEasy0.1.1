﻿using System;
using System.Data;
using System.Windows.Forms;
using BLL;

namespace BillEasy0._1._0
{
    public partial class ConsultaUsuario : Form
    {
        ErrorProvider miError;
        public ConsultaUsuario()
        {
            InitializeComponent();
            miError = new ErrorProvider();
            BuscarcomboBox.SelectedIndex = 0;
        }

     
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            DataTable dataTable = new DataTable();
            string condicion;

         
            
                if (BuscarcomboBox.SelectedIndex == 0)
                {
                    if(DatostextBox.Text.Trim().Length == 0)
                    {
                        condicion = "1=1";
                    }
                    else
                    {
                        condicion = "UsuarioId = " + DatostextBox.Text;
                    }
                    dataTable = usuario.Listado(" UsuarioId, Nombres, NombreUsuario, Contrasena, Area, Fecha",condicion, "");
                    DatosdataGridView.DataSource = dataTable;
                }
            
            if(BuscarcomboBox.SelectedIndex == 1)
            {
                if(DatostextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2";
                }
                else
                {
                    condicion = string.Format("Nombres = '{0}' ", DatostextBox.Text);
                }
                dataTable = usuario.Listado(" UsuarioId, Nombres, NombreUsuario, Contrasena, Area, Fecha ", condicion, "");
                DatosdataGridView.DataSource = dataTable;

            }
            if(BuscarcomboBox.SelectedIndex == 2)
            {
                if(DatostextBox.Text.Trim().Length == 2)
                {
                    condicion = "3=3";
                }
                else
                {
                    condicion = string.Format("NombreUsuario = '{0}'",DatostextBox.Text);
                }
                dataTable = usuario.Listado(" UsuarioId, Nombres, NombreUsuario, Contrasena, Area, Fecha ", condicion, "");
                DatosdataGridView.DataSource = dataTable;
            }
            if(BuscarcomboBox.SelectedIndex == 3)
            {
                if(DatostextBox.Text.Trim().Length == 3)
                {
                    condicion = "4=4";
                }
                else
                {
                    condicion = string.Format("Area = '{0}'",DatostextBox.Text);
                }
                dataTable = usuario.Listado(" UsuarioId, Nombres, NombreUsuario, Contrasena, Area, Fecha ", condicion, "");
                DatosdataGridView.DataSource = dataTable;
            }

        }

       
    }
}
