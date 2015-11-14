using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Ciudades : ClaseMaestra
    {
        public int CiudadId { get; set; }
        public string Nombre { get; set; }
        public int CodigoPostal { get; set; }

        public Ciudades()
        {
            this.CiudadId = 0;
            this.Nombre = "";
            this.CodigoPostal = 0;
        }

        public Ciudades(int ciudadId,string nombre, int codigoPostal)
        {
            this.CiudadId = ciudadId;
            this.Nombre = nombre;
            this.CodigoPostal = codigoPostal;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Insert Into Ciudades(Nombre,CodigoPostal) Values('{0}',{1})",this.Nombre,this.CodigoPostal));  
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Update Ciudades set Nombre = '{0}', CodigoPostal = {1} where CiudadId = {2} ",this.Nombre,this.CodigoPostal,this.CiudadId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete Ciudades where CiudadId = {0}",this.CiudadId));
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();
            dt = (conexion.ObtenerDatos(String.Format("Select CiudadId, Nombre, CodigoPostal From Ciudades where CiudadId = {0}",idBuscado)));
            if(dt.Rows.Count > 0)
            {
                this.CiudadId = (int)dt.Rows[0]["CiudadId"];
                this.Nombre = dt.Rows[0]["Nombre"].ToString();
                this.CodigoPostal = (int)dt.Rows[0]["CodigoPostal"];
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
                " From Ciudades Where " + condicion + "" + ordenFinal);
        }
    }
}
