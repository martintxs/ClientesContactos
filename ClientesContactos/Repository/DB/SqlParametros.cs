using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DB
{
	public class SqlParametros
	{
		private List<SqlParameter> _parametros = new List<SqlParameter>();

		public List<SqlParameter> Parametros
		{
			get
			{
				return _parametros;
			}
			set
			{
				_parametros = value;
			}
		}

		public SqlParametros()
		{
		}

		public SqlParametros(string nombre, object valor)
		{
			agregar(nombre, valor);
		}

		public void agregar(string nombre, object valor)
		{
			SqlParameter sqlParameter = new SqlParameter();
			sqlParameter.ParameterName = nombre;
			sqlParameter.Value = valor;
			_parametros.Add(sqlParameter);
		}

		public void agregar(string nombre, object valor, bool esSalida)
		{
			SqlParameter sqlParameter = new SqlParameter();
			sqlParameter.ParameterName = nombre;
			sqlParameter.Value = valor;
			sqlParameter.Direction = ((!esSalida) ? ParameterDirection.Input : ParameterDirection.Output);
			_parametros.Add(sqlParameter);
		}
	}
}
