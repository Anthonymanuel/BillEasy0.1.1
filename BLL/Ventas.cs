using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Ventas : ClaseMaestra
    {
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public string Fecha { get; set; }
        public float ITBIS { get; set; }
        public float Descuento { get; set; }
        public string TipoVenta { get; set; }
        public string NFC { get; set; }
        public string TipoNFC { get; set; }
        public float Total { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public List<Usuarios> Usuario { get; set; }

        public Ventas()
        {
            this.VentaId = 0;
            this.ClienteId = 0;
            this.Fecha = "";
            this.ITBIS = 0f;
            this.Descuento = 0f;
            this.TipoVenta = "";
            this.NFC = "";
            this.TipoNFC = "";
            this.Total = 0f;
            this.Cantidad = 0;
            this.Precio = 0f;
            Usuario = new List<Usuarios>();
        }
        public void AgregarUsuario(int usuarioId,string nombre)
        {
            this.Usuario.Add(new Usuarios(usuarioId, nombre));
        }
        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            StringBuilder comando = new StringBuilder();
            bool retorno = false;

            retorno = conexion.Ejecutar(String.Format("Insert into Ventas(ClienteId,Fecha,ITBIS,Descuento,TipoVenta,NFC,TipoNFC,Total) values({0},'{1}',{2},{3},'{4}','{5}','{6}',{7})", this.ClienteId, this.Fecha, this.ITBIS, this.Descuento, this.TipoVenta, this.NFC, this.TipoNFC, this.Total));

            if (retorno)
            {
                this.VentaId = (int)conexion.ObtenerDatos("Select MAX(VentaId) as VentaId from Ventas").Rows[0]["VentaId"];

                foreach(var usuario in Usuario)
                {
                    comando.AppendLine(String.Format("Insert into DetallesVentas(VentaId,UsuarioId,ClienteId,Cantidad,Precio) values({0},{1},{2},{3},{4})",this.VentaId,usuario.UsuarioId,this.ClienteId,this.Cantidad,this.Precio));
                }

                retorno = conexion.Ejecutar(comando.ToString());
            }

            return retorno;
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            StringBuilder comando = new StringBuilder();
            bool retorno = false;

            retorno = conexion.Ejecutar(String.Format("Update Ventas set ClienteId = {0},Fecha = '{1}',ITBIS = {2},Descuentos = {3},TipoVenta = {4},NFC = {5},TipoNFC = {6},Total = {7} where VentaId = {8}",ClienteId,Fecha,TipoVenta,NFC,TipoNFC,Total,this.VentaId));

            if (retorno)
            {
                conexion.Ejecutar("Delete from DetallesVentas where VentasId = " + this.VentaId);

                foreach(var usuario in Usuario)
                {
                    comando.AppendLine(String.Format("Insert into DetallesVentas(VentaId,UsuarioId,ClienteId,Cantidad,Precio) values({0},{1},{2},{3},{4})", this.VentaId, usuario.UsuarioId, this.ClienteId, this.Cantidad, this.Precio));
                }
                retorno = conexion.Ejecutar(comando.ToString());
            }
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            retorno = conexion.Ejecutar("Delete from Ventas where VentaId =" +this.VentaId + ";" + "Delete from DetallesVentas where VentaId = " +this.VentaId);

            return retorno;

        }

        public override bool Buscar(int idBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            DataTable dtUsuarios = new DataTable();

            dt = conexion.ObtenerDatos(String.Format("Select *from Ventas where VentaId = {0} ",idBuscado));
            dtUsuarios = conexion.ObtenerDatos(String.Format("Select V.VentaId,D.UsuarioId,D.ClienteId,D.Cantidad,D.Precio from DetallesVentas D inner join Ventas V on D.VentaId = V.VentaId where VentaId = {0} ", idBuscado));

            if (dt.Rows.Count > 0)
            {
                this.ClienteId = (int)dt.Rows[0]["ClieneteId"];
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
                this.ITBIS = (float)dt.Rows[0]["ITBIS"];
                this.Descuento = (float)dt.Rows[0]["Descuento"];
                this.TipoVenta = dt.Rows[0]["TipoVenta"].ToString();
                this.NFC = dt.Rows[0]["NFC"].ToString();
                this.TipoNFC = dt.Rows[0]["TipoNFC"].ToString();
                this.Total = (float)dt.Rows[0]["Total"];

                this.Usuario.Clear();
                foreach(DataRow row in dtUsuarios.Rows)
                {
                    this.AgregarUsuario((int)row["UsuarioId"],row["Nombres"].ToString());
                }
            }

            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            ConexionDb conexion = new ConexionDb();
            string ordenFinal = "";
            if (!orden.Equals(""))
                ordenFinal = " Orden by  " + orden;

            return conexion.ObtenerDatos("Select " + campos +
                " From Ventas Where " + condicion + "" + ordenFinal);
        }
    }
}
