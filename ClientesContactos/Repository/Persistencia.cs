using ModelosDeProceso.Colecciones;
using ModelosDeProceso.ModelosDeProceso;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Persistencia
    {
        public static string cadenaDeConexion()
        {
            string conn = ConfigurationManager.ConnectionStrings["ConexionPrincipal"].ConnectionString;
            return conn;
        }

        private static string nombreSp(object modelo, string funcion)
        {
            return $"sp{ modelo.GetType().Name }_{funcion}";
        }

        public static void sp(SqlParametros parametros, ref DataSet resultados, object modelo, [CallerMemberName] string funcion = "")
        {
            DataLayer.sp(parametros, ref resultados, cadenaDeConexion(), nombreSp(modelo, funcion));
        }
    }
}
