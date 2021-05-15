using Model.Model.Contacto;
using ModelosDeProceso.Colecciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contacto
{
    public class Contacto : IContacto
    {
        private DataSet respuesta;
        private SqlParametros parametros;

        public DataSet Delete(int Id)
        {
            parametros = new SqlParametros();
            parametros.agregar("@IdContacto", Id);
            respuesta = new DataSet();
            Persistencia.sp(parametros, ref respuesta, new Contacto());
            return respuesta;
        }

        public DataSet ReadAll(int Id)
        {
            parametros = new SqlParametros();
            parametros.agregar("@IdCliente", Id);
            respuesta = new DataSet();
            Persistencia.sp(parametros, ref respuesta, new Contacto());
            return respuesta;
        }

        public DataSet ReadId(int Id)
        {
            parametros = new SqlParametros();
            parametros.agregar("@IdContacto", Id);
            respuesta = new DataSet();
            Persistencia.sp(parametros, ref respuesta, new Contacto());
            return respuesta;
        }

        public DataSet Save(VoContacto Contacto)
        {
            parametros = new SqlParametros();
            parametros.agregar("@IdContacto", Contacto.IdContacto);
            parametros.agregar("@Nombre", Contacto.Nombre);
            parametros.agregar("@ApellidoPaterno", Contacto.ApellidoPaterno);
            parametros.agregar("@ApellidoMaterno", Contacto.ApellidoMaterno);
            parametros.agregar("@Puesto", Contacto.Puesto);
            parametros.agregar("@Telefono", Contacto.Telefono);
            parametros.agregar("@Direccion", Contacto.Direccion);
            respuesta = new DataSet();
            Persistencia.sp(parametros, ref respuesta, new Contacto());
            return respuesta;
        }
    }
}
