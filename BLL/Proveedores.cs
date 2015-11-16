using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class Proveedores : ClaseMaestra
    {
        public int ProveedorId { get; set; }
        public int CiudadId { get; set; }
        public string NombreEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string RNC { get; set; }
        public string NombreRepresentante { get; set; }
        public string Celular { get; set; }


        public Proveedores()
        {
            this.ProveedorId = 0;
            this.CiudadId = 0;
            this.NombreEmpresa = "";
            this.Direccion = "";
            this.Telefono = "";
            this.Email = "";
            this.RNC = "";
            this.NombreRepresentante = "";
            this.Celular = "";
        }



        public Proveedores(int proveedorId, int ciudadId, string nombreEmpresa, string direccion, string telefono, string email, string rNC, string nombreRepresentante, string celular)
        {
            this.ProveedorId = proveedorId;
            this.CiudadId = ciudadId;
            this.NombreEmpresa = nombreEmpresa;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.RNC = rNC;
            this.NombreRepresentante = nombreRepresentante;
            this.Celular = celular;
        }

        public override bool Insertar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Insert Into Proveedores(CiudadId,NombreEmpresa,Direccion,Telefono,Email,RNC,NombreRepresentante,Celular) Values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')", this.CiudadId, this.NombreEmpresa, this.Direccion, this.Telefono, this.Email, this.RNC, this.NombreRepresentante, this.Celular));
            return retorno;
        }

        public override bool Editar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Update Proveedores Set CiudadId = {0},NombreEmpresa ='{1}', Direccion ='{2}', Telefono ='{3}', Email ='{4}', RNC='{5}', NombreRepresentante = '{6}', Celular ='{7}' Where ProveedorId ={8}", this.CiudadId, this.NombreEmpresa, this.Direccion, this.Telefono, this.Email, this.RNC, this.NombreRepresentante, this.Celular, this.ProveedorId));
            return retorno;
        }

        public override bool Eliminar()
        {
            bool retorno = false;
            ConexionDb conexion = new ConexionDb();
            retorno = conexion.Ejecutar(String.Format("Delete Proveedores where ProveedorId = {0}", this.ProveedorId));
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            DataTable dt = new DataTable();
            ConexionDb conexion = new ConexionDb();
            dt = conexion.ObtenerDatos((String.Format("Select ProveedorId,CiudadId, NombreEmpresa,Direccion,Telefono,Email,RNC,NombreRepresentante,Celular From Proveedores where ProveedorId = {0} ", idBuscado)));

            if (dt.Rows.Count > 0)
            {
                this.ProveedorId = (int)dt.Rows[0]["ProveedorId"];
                this.CiudadId = (int)dt.Rows[0]["CiudadId"];
                this.NombreEmpresa = dt.Rows[0]["NombreEmpresa"].ToString();
                this.Direccion = dt.Rows[0]["Direccion"].ToString();
                this.Telefono = dt.Rows[0]["Telefono"].ToString();
                this.Email = dt.Rows[0]["Email"].ToString();
                this.RNC = dt.Rows[0]["RNC"].ToString();
                this.NombreRepresentante = dt.Rows[0]["NombreRepresentante"].ToString();
                this.Celular = dt.Rows[0]["Celular"].ToString();
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
               " From Proveedores Where " + condicion + "" + ordenFinal);
        }
    }
}
