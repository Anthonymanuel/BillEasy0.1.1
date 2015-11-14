﻿using System;
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
    public partial class RegistroProducto : Form
    {
        ErrorProvider miError;
        public RegistroProducto()
        {
            InitializeComponent();
            miError = new ErrorProvider();
        }
        private void LLenarDatos(Productos producto)
        {
            float precio, costo, itbis;
            int cantidad;
            float.TryParse(PrecioTextBox.Text, out precio);
            float.TryParse(CostoTextBox.Text, out costo);
            float.TryParse(ITBISTextBox.Text, out itbis);
            int.TryParse(CantidadTextBox.Text, out cantidad);
            //producto.ProveedorId = ProveedorTextBox.Text;
            //producto.MarcaId = MarcaTextBox.Text;
            producto.Nombre = NombreTextBox.Text;
            producto.Cantidad = cantidad;
            producto.Precio = precio;
            producto.Costo = costo;
            producto.ITBIS = itbis;
        }
        private int Error()
        {
            int contador = 0;
           
            if (NombreTextBox.Text == "")
            {
                miError.SetError(NombreTextBox, "Debe llenar el nombre del producto");
                contador = 1;
            }
            if (CantidadTextBox.Text == "")
            {
                miError.SetError(CantidadTextBox, "Debe llenar la cantidad");
                contador = 1;
            }
            if (PrecioTextBox.Text == "")
            {
                miError.SetError(PrecioTextBox, "Debe llenar el precio");
                contador = 1;
            }
            if (CostoTextBox.Text == "")
            {
                miError.SetError(CostoTextBox, "Debe llenar el Costo");
                contador = 1;
            }
            if (ITBISTextBox.Text == "")
            {
                miError.SetError(ITBISTextBox, "Debe llenar el ITBIS");
                contador = 1;
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
            if (!Regex.Match(CantidadTextBox.Text, @"(\d+( \.)?\d*)").Success)
            {
                MessageBox.Show("la cantidad debe de ser entera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            if (!Regex.Match(PrecioTextBox.Text, @"(\d+( \.)?\d*)").Success)
            {
                MessageBox.Show("El precio debe ser numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            if (!Regex.Match(CostoTextBox.Text, @"(\d+( \.)?\d*)").Success)
            {
                MessageBox.Show("Costo debe ser numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            if (!Regex.Match(ITBISTextBox.Text, @"(\d+( \.)?\d*)").Success)
            {
                MessageBox.Show("ITBIS debe ser numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NombreTextBox.Focus();
            }
            else
            {
                Regex espacio = new Regex(@"\s+");
                NombreTextBox.Text = espacio.Replace(NombreTextBox.Text, " ");
                retorno += 1;
            }

            return retorno;
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            int id;
            int.TryParse(ProductoIdTextBox.Text, out id);
            producto.Buscar(id);
            ProductoIdTextBox.Text = producto.ProductoId.ToString();
            //ProveedorTextBox.Text = producto.ProveedorId.ToString();
            //MarcaTextBox.Text = producto.MarcaId.ToString();
            NombreTextBox.Text = producto.Nombre.ToString();
            CantidadTextBox.Text = producto.Cantidad.ToString();
            PrecioTextBox.Text = producto.Precio.ToString();
            CostoTextBox.Text = producto.Costo.ToString();
            ITBISTextBox.Text = producto.ITBIS.ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ProductoIdTextBox.Clear();
            NombreTextBox.Clear();
            CantidadTextBox.Clear();
            PrecioTextBox.Clear();
            CostoTextBox.Clear();
            ITBISTextBox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Error();
            Validar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            if (ProductoIdTextBox.TextLength > 0)
            {
                int id;
                int.TryParse(ProductoIdTextBox.Text, out id);
                producto.ProveedorId = id;
                if (producto.Eliminar())
                    MessageBox.Show("Producto Eliminado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevobutton.PerformClick();
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
