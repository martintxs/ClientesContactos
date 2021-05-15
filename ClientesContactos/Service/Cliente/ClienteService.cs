using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Model.Model.Cliente;
using Model.Model.Respuesta;
using Reports.Reporte;
using Repository.Cliente;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
                                 Estatus = Convert.ToBoolean( d.Field<object>("Estatus")),
                                 Mensaje = d.Field<string>("Mensaje")
                             }).FirstOrDefault();
            return respuesta;
        }

        public (VoRespuesta, List<VoCliente>) ReadAll(VoCliente Cliente)
        {
            VoRespuesta voRespuesta = new VoRespuesta { Estatus = true };
            var respuesta = new List<VoCliente>();
            try
            {
                var resultado = _ICliente.ReadAll(Cliente);
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
                var resultado = _ICliente.ReadId(Id);
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

        public (VoRespuesta, byte[]) Reporte(int Id)
        {
            VoRespuesta voRespuesta = new VoRespuesta { Estatus = true };
            byte[] respuesta = null;
            try
            {
                ReportDocument rptCliente = new Reporte();
                var ds = _ICliente.Reporte(Id);
                ds.Tables[0].TableName = "dtCliente";
                ds.Tables[1].TableName = "dtContactos";
                rptCliente.SetDataSource(ds);
                Stream pdf = rptCliente.ExportToStream(ExportFormatType.PortableDocFormat);
                
                rptCliente.Close();

                using (BinaryReader br = new BinaryReader(pdf))
                {
                    respuesta = br.ReadBytes((int)pdf.Length);
                }
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
                                 Estatus = Convert.ToBoolean(d.Field<object>("Estatus")),
                                 Mensaje = d.Field<string>("Mensaje")
                             }).FirstOrDefault();
            return respuesta;
        }

    }
}
