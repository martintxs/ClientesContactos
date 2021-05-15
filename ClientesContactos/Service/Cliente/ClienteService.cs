using Model.Model.Cliente;
using Model.Model.Respuesta;
using Repository.Cliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Service.Cliente
{
    public class ClienteService : IClienteService
    {
        private readonly ICliente _ICliente;

        public ClienteService()
        {
            _ICliente = new Repository.Cliente.Cliente();
        }

        public VoRespuesta Delete(int Id)
        {
            var resultado = _ICliente.Delete(Id);
            var respuesta = (from DataRow d in resultado.Tables[0].AsEnumerable()
                             select new VoRespuesta
                             {
                                 Estatus = d.Field<bool>("Estatus"),
                                 Mensaje = d.Field<string>("Mensaje")
                             }).FirstOrDefault();
            return respuesta;
        }

        public (VoRespuesta, List<VoCliente>) ReadAll()
        {
            VoRespuesta voRespuesta = new VoRespuesta { Estatus = true };
            var respuesta = new List<VoCliente>();
            try
            {
                var resultado = _ICliente.ReadAll();
                respuesta = (from DataRow d in resultado.Tables[0].AsEnumerable()
                             select new VoCliente
                             {
                                 IdCliente = d.Field<int>("IdCliente"),
                                 RazonSocial = d.Field<string>("RazonSocial"),
                                 NombreComercial = d.Field<string>("NombreComercial"),
                                 RFC = d.Field<string>("RFC"),
                                 CURP = d.Field<string>("CURP"),
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

        public (VoRespuesta, VoCliente) ReadId(int Id)
        {
            VoRespuesta voRespuesta = new VoRespuesta { Estatus = true };
            var respuesta = new VoCliente();
            try
            {
                var resultado = _ICliente.ReadAll();
                respuesta = (from DataRow d in resultado.Tables[0].AsEnumerable()
                             select new VoCliente
                             {
                                 IdCliente = d.Field<int>("IdCliente"),
                                 RazonSocial = d.Field<string>("RazonSocial"),
                                 NombreComercial = d.Field<string>("NombreComercial"),
                                 RFC = d.Field<string>("RFC"),
                                 CURP = d.Field<string>("CURP"),
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

        public VoRespuesta Save(VoCliente Cliente)
        {
            var resultado = _ICliente.Save(Cliente);
            var respuesta = (from DataRow d in resultado.Tables[0].AsEnumerable()
                             select new VoRespuesta
                             {
                                 Estatus = d.Field<bool>("Estatus"),
                                 Mensaje = d.Field<string>("Mensaje")
                             }).FirstOrDefault();
            return respuesta;
        }

    }
}
