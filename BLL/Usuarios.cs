using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Usuarios : ClaseMaestra
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Area { get; set; }
        public string Fecha { get; set; }

        public Usuarios()
        {
            this.UsuarioId = 0;
            this.Nombre = "";
            this.NombreUsuario = "";
            this.Contrasena = "";
            this.Area = "";
            this.Fecha = "";
        }
        
        public Usuarios(int usuarioId, string nombre, string nombreUsuario, string contrasena, string area, string fecha)
        {
            this.UsuarioId = usuarioId;
            this.Nombre = nombre;
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = contrasena;
            this.Area = area;
            this.Fecha = fecha;
        }

        public string VerificarUsuario()
        {
            ConexionDb conexion = new ConexionDb();
            string respuesta;

            try
            {
                respuesta = conexion.ObtenerDatos(string.Format("Select NombreUsuario from Usuarios where NombreUsuario = '{0}'",this.NombreUsuario)).Rows[0]["NombreUsuario"].ToString();
            }catch(Exception)
            {
                return "";
            }
            return respuesta;
        }

        public string VerificarContrasena()
        {
            ConexionDb conexion = new ConexionDb();
            string respuesta2;

            try
            {
                respuesta2 = conexion.ObtenerDatos(string.Format("Select Contrasena from Usuarios where Contrasena = '{0}'", this.Contrasena)).Rows[0]["Contrasena"].ToString();
            }
            catch (Exception)
            {
                return "";
            }
            return respuesta2;
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;

            retorno = conexion.Ejecutar(string.Format("Insert into Usuarios(Nombres,NombreUsuario,Contrasena,Area,Fecha) values('{0}','{1}','{2}','{3}','{4}')", this.Nombre, this.NombreUsuario, this.Contrasena, this.Area, this.Fecha));

            return retorno;
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            retorno = conexion.Ejecutar(string.Format("Update Usuarios set Nombres = '{0}',NombreUsuario = '{1}',Contrasena = '{2}',Area = '{3}',Fecha = '{4}' where UsuarioId = '{5}'",this.Nombre,this.NombreUsuario,this.Contrasena,this.Area,this.Fecha,this.UsuarioId));
            return retorno;
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            retorno = conexion.Ejecutar(string.Format("Delete Usuarios where UsuarioId = {0}",this.UsuarioId));
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            dt = (conexion.ObtenerDatos(String.Format("Select UsuarioId, Nombres,NombreUsuario,Contrasena,Area,Fecha From Usuarios Where UsuarioId = {0}", idBuscado)));
            if (dt.Rows.Count > 0)
            {
                this.UsuarioId = (int)dt.Rows[0]["UsuarioId"];
                this.Nombre = dt.Rows[0]["Nombres"].ToString();
                this.NombreUsuario = dt.Rows[0]["NombreUsuario"].ToString();
                this.Contrasena = dt.Rows[0]["Contrasena"].ToString();
                this.Area = dt.Rows[0]["Area"].ToString();
                this.Fecha = dt.Rows[0]["Fecha"].ToString();
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
                " From Usuarios Where " + condicion + ""+ordenFinal);
        }
    }
}
