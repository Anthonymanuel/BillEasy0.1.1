using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Compras : ClaseMaestra
    {
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int ProveedorId { get; set; }
        public int UsuarioId { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public string TipoCompra { get; set; }
        public string NFC { get; set; }
        public string TiopNFC { get; set; }
        public float Flete { get; set; }
        public float Monto { get; set; }
        public float Costo { get; set; }
        public List<Productos> Producto { get; set; }

        public Compras()
        {
            this.CompraId = 0;
            this.ProductoId = 0;
            this.ProveedorId = 0;
            this.UsuarioId = 0;
            this.Fecha = "";
            this.Cantidad = 0;
            this.TipoCompra = "";
            this.NFC = "";
            this.TiopNFC = "";
            this.Flete = 0f;
            this.Costo = 0f;
            this.Monto = 0f;
            Producto = new List<Productos>();
        }

        public void AgregarProducto(int productoId)
        {
            this.Producto.Add(new Productos(productoId));
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno;
            StringBuilder comando = new StringBuilder();

            retorno = conexion.Ejecutar(String.Format("Insert Into Compras(ProveedorId,UsuarioId ,Fecha ,Cantidad ,TipoCompra ,NFC ,TiopNFC ,Flete , Costo, Monto ) Values({0},{1},'{2}',{3},'{4}','{5}','{6}',{7},{8},{9})",this.ProveedorId,this.UsuarioId,this.Fecha,this.Cantidad,this.TipoCompra,this.NFC,this.TiopNFC,this.Flete ,this.Costo,this.Monto ));

            if (retorno)
            {
                this.CompraId = (int)conexion.ObtenerDatos("Select MAX(CompraId) as CompraId from Compras").Rows[0]["CompraId"];

                foreach (var producto in Producto)
                {
                    comando.AppendLine(String.Format("Insert into DetallesVentas(ProductoId) values({0})", producto.ProductoId));
                }

                retorno = conexion.Ejecutar(comando.ToString());
            }
            return retorno;
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            StringBuilder comando = new StringBuilder();

            retorno = conexion.Ejecutar(String.Format("Update Compras set ProveedorId = {0}, UsuarioId = {1},Fecha = '{2}',Cantidad = {3},TipoCompra = '{4}' ,NFC = '{5}' ,TiopNFC ='{6}' ,Flete ={7} , Costo ={8}, Monto = {9} Where CompraId = {10}", this.ProveedorId, this.UsuarioId, this.Fecha, this.Cantidad, this.TipoCompra, this.NFC, this.TiopNFC, this.Flete, this.Costo, this.Monto,this.CompraId));
            if (retorno)
            {
                conexion.Ejecutar("Delete from DetallesCompras where CompraId = " + this.CompraId);

                /*foreach()
                {
                    comando.AppendLine(String.Format("Insert into DetallesVentas(VentaId,UsuarioId,ClienteId,ProductoId,Cantidad,Precio) values({0},{1},{2},{3},{4},{5})", this.VentaId, usuario.UsuarioId, this.ClienteId,this.ProductoId, this.Cantidad, this.Precio));
                }*/
                retorno = conexion.Ejecutar(comando.ToString());
            }
            return retorno;
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            retorno = conexion.Ejecutar("Delete From Compras where CompraId = "+this.CompraId+";"
                                        +"Delete From  DetallesCompras Where CompraId = "+this.CompraId);
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dt = new DataTable();
            DataTable dtProducto = new DataTable();
            ConexionDb conexion = new ConexionDb();
            dt = conexion.ObtenerDatos(String.Format("Select * From Compras Where CompraId = {0} ",idBuscado));
            if(dt.Rows.Count > 0)
            {
                this.CompraId =(int)dt.Rows[0]["CompraId"];
                this.ProductoId = (int)dt.Rows[0]["ProductoId"];
                this.ProveedorId = (int)dt.Rows[0]["ProveedorId"];
                this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.Cantidad = (int)dt.Rows[0]["Cantidad"];
                this.TipoCompra = dt.Rows[0]["TipoCompra"].ToString();
                this.NFC = dt.Rows[0]["NFC"].ToString();
                this.TiopNFC = dt.Rows[0]["TipoNFC"].ToString();
                this.Flete = (float)dt.Rows[0]["Flete"];
                this.Costo = (float)dt.Rows[0]["Costo"];
                this.Monto = (float)dt.Rows[0]["Monto"];

                this.Producto.Clear();
                foreach (DataRow row in dtProducto.Rows)
                {
                    this.AgregarProducto((int)row["UsuarioId"]);
                }
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!orden.Equals(""))
                ordenFinal = " Ordden by " + orden;
            return conexion.ObtenerDatos("Select " + campos +
                " From Usuarios Where " + condicion + "" + ordenFinal);
        }
    }
}
