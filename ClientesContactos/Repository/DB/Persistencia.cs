using Repository.DB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
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

        public static void sp(SqlParametros parametros, ref DataSet resultados, object modelo)
        {
            ConexionBaseDeDatos conexionBaseDeDatos = new ConexionBaseDeDatos(cadenaDeConexion());
            string nombre = formularNombreSp(modelo)/*nombreSp(modelo, "")*/;
            DataSet dataSet = conexionBaseDeDatos.ejecutarSpDataSet(nombre, parametros);
            resultados = dataSet;
        }

        public static string formularNombreSp(object modelo)
        {
            StackTrace stackTrace = new StackTrace();
            string str = "sp";
            str += modelo.GetType().Name;
            str += "_";
            str = str + stackTrace.GetFrame(3).GetMethod().Name;
            return str;
        }

    }
}
