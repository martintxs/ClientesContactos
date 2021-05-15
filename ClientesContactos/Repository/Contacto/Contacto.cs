using Model.Model.Contacto;
using Repository.DB;
using System.Data;


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

        public DataSet ReadAll(VoContacto Contacto)
        {
            parametros = new SqlParametros();
            parametros.agregar("@IdCliente", Contacto.IdCliente);
            parametros.agregar("@Nombre", Contacto.Nombre ?? "");
            parametros.agregar("@ApellidoPaterno", Contacto.ApellidoPaterno ?? "");
            parametros.agregar("@ApellidoMaterno", Contacto.ApellidoMaterno ?? "");
            parametros.agregar("@Telefono", Contacto.Telefono ?? "");
            parametros.agregar("@Direccion", Contacto.Direccion ?? "");
            parametros.agregar("@Puesto", Contacto.Puesto ?? "");
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
            parametros.agregar("@IdCliente", Contacto.IdCliente);
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
