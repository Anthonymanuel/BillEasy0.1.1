using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Marcas : ClaseMaestra
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }

        public Marcas()
        {
            this.MarcaId = 0;
            this.Nombre = "";
        }

        public Marcas(int marcaId, string nombre)
        {
            this.MarcaId = marcaId;
            this.Nombre = Nombre = nombre;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Insert Into Marcas(Nombre) Values('{0}')",this.Nombre));
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Update Marcas set Nombre = '{0}' where MarcaId = {1} ",this.Nombre,this.MarcaId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete  Marcas where MarcaId = {0}", this.MarcaId));
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            dt = (conexion.ObtenerDatos(String.Format("Select MarcaId, Nombre From Marcas Where MarcaId = {0}", idBuscado)));
            if (dt.Rows.Count > 0)
            {
                this.MarcaId = (int)dt.Rows[0]["MarcaId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
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
                " From Marcas Where " + condicion + "" + ordenFinal);
        }
    }
}
