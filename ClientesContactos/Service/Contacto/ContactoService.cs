using Model.Model.Contacto;
using Model.Model.Respuesta;
using Repository.Contacto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Service.Contacto
{
    public class ContactoService : IContactoService
    {
        private readonly IContacto _IContacto;
        public ContactoService()
        {
            _IContacto = new Repository.Contacto.Contacto();
        }

        public VoRespuesta Delete(int Id)
        {
            var resultado = _IContacto.Delete(Id);
            var respuesta = (from DataRow d in resultado.Tables[0].AsEnumerable()
                             select new VoRespuesta
                             {
                                 Estatus = Convert.ToBoolean(d.Field<object>("Estatus")),
                                 Mensaje = d.Field<string>("Mensaje")
                             }).FirstOrDefault();
            return respuesta;
        }

        public (VoRespuesta, List<VoContacto>) ReadAll(VoContacto Contacto)
        {
            VoRespuesta voRespuesta = new VoRespuesta { Estatus = true };
            var respuesta = new List<VoContacto>();
            try
            {
                var resultado = _IContacto.ReadAll(Contacto);
                respuesta = (from DataRow d in resultado.Tables[0].AsEnumerable()
                             select new VoContacto
                             {
                                 IdContacto = d.Field<int>("IdContacto"),
                                 Nombre = d.Field<string>("Nombre"),
                                 ApellidoPaterno = d.Field<string>("ApellidoPaterno"),
                                 ApellidoMaterno = d.Field<string>("ApellidoMaterno"),
                                 Puesto = d.Field<string>("Puesto"),
                                 Telefono = d.Field<string>("Telefono"),
                                 Direccion = d.Field<string>("Direccion")
                             }).ToList();
            }
            catch (Exception ex)
            {
                voRespuesta.Estatus = false;
                voRespuesta.Mensaje = ex.Message;
                return (voRespuesta, respuesta);
            }

            return (voRespuesta, respuesta);
        }


        public (VoRespuesta, VoContacto) ReadId(int Id)
        {
            VoRespuesta voRespuesta = new VoRespuesta { Estatus = true };
            var respuesta = new VoContacto();
            try
            {
                var resultado = _IContacto.ReadId(Id);
                respuesta = (from DataRow d in resultado.Tables[0].AsEnumerable()
                             select new VoContacto
                             {
                                 IdContacto = d.Field<int>("IdContacto"),
                                 Nombre = d.Field<string>("Nombre"),
                                 ApellidoPaterno = d.Field<string>("ApellidoPaterno"),
                                 ApellidoMaterno = d.Field<string>("ApellidoMaterno"),
                                 Puesto = d.Field<string>("Puesto"),
                                 Telefono = d.Field<string>("Telefono"),
                                 Direccion = d.Field<string>("Direccion")
                             }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                voRespuesta.Estatus = false;
                voRespuesta.Mensaje = ex.Message;
                return (voRespuesta, respuesta);
            }

            return (voRespuesta, respuesta);
        }

        public VoRespuesta Save(VoContacto Contacto)
        {
            var resultado = _IContacto.Save(Contacto);
            var respuesta = (from DataRow d in resultado.Tables[0].AsEnumerable()
                             select new VoRespuesta
                             {
                                 Estatus = Convert.ToBoolean(d.Field<object>("Estatus")),
                                 Mensaje = d.Field<string>("Mensaje")
                             }).FirstOrDefault();
            return respuesta;
        }
    }
}
