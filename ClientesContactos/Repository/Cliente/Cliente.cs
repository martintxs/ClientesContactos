using Model.Model.Cliente;
using ModelosDeProceso.Colecciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Cliente
{
    public class Cliente : ICliente
    {
        private DataSet respuesta;
        private SqlParametros parametros;

        public DataSet Delete(int Id)
        {
            parametros = new SqlParametros();
            parametros.agregar("@IdCliente", Id);
            respuesta = new DataSet();
            Persistencia.sp(parametros, ref respuesta, new Cliente());
            return respuesta;
        }

        public DataSet ReadAll()
        {
            parametros = new SqlParametros();
            respuesta = new DataSet();
            Persistencia.sp(parametros, ref respuesta, new Cliente());
            return respuesta;
        }

        public DataSet ReadId(int Id)
        {
            parametros = new SqlParametros();
            parametros.agregar("@IdCliente", Id);
            respuesta = new DataSet();
            Persistencia.sp(parametros, ref respuesta, new Cliente());
            return respuesta;
        }

        public DataSet Save(VoCliente Cliente)
        {
            parametros = new SqlParametros();
            parametros.agregar("@IdCliente", Cliente.IdCliente);
            parametros.agregar("@RazonSocial", Cliente.RazonSocial);
            parametros.agregar("@NombreComercial", Cliente.NombreComercial);
            parametros.agregar("@RFC", Cliente.RFC);
            parametros.agregar("@CURP", Cliente.CURP);
            parametros.agregar("@Direccion", Cliente.Direccion);
            respuesta = new DataSet();
            Persistencia.sp(parametros, ref respuesta, new Cliente());
            return respuesta;
        }
    }
}
