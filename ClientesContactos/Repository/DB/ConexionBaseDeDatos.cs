using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DB
{
	public class ConexionBaseDeDatos
	{
		private string _cadenaConexion;

		private SqlConnection _conexion;

		public ConexionBaseDeDatos(string cadenaDeConexion)
		{
			_cadenaConexion = cadenaDeConexion;
		}

		public void ejecutarSp(string nombreSp)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public void ejecutarSp(string nombreSp, SqlParametros parametros)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				foreach (SqlParameter parametro in parametros.Parametros)
				{
					sqlCommand.Parameters.Add(parametro);
				}
				sqlCommand.ExecuteNonQuery();
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public object ejecutarSpEscalar(string nombreSp)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				return sqlCommand.ExecuteScalar();
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public object ejecutarSpEscalar(string nombreSp, SqlParametros parametros)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				foreach (SqlParameter parametro in parametros.Parametros)
				{
					sqlCommand.Parameters.Add(parametro);
				}
				return sqlCommand.ExecuteScalar();
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public DataSet ejecutarSpDataSet(string nombreSp)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			SqlDataAdapter sqlAdapter = new SqlDataAdapter();
			DataSet dataSet = new DataSet();
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlAdapter.SelectCommand = sqlCommand;
				sqlAdapter.Fill(dataSet);

				return dataSet;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public DataTable ejecutarSpDatos(string nombreSp)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlDataAdapter.SelectCommand = sqlCommand;
				sqlDataAdapter.Fill(dataTable);
				return dataTable;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public DataSet ejecutarSelectDataSet(string select)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataSet dataSet = new DataSet();
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(select, _conexion);
				sqlCommand.CommandType = CommandType.Text;
				sqlDataAdapter.SelectCommand = sqlCommand;
				sqlDataAdapter.Fill(dataSet);
				return dataSet;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public DataTable ejecutarSelectDatos(string select)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(select, _conexion);
				sqlCommand.CommandType = CommandType.Text;
				sqlDataAdapter.SelectCommand = sqlCommand;
				sqlDataAdapter.Fill(dataTable);
				return dataTable;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public DataSet ejecutarSpDataSet(string nombreSp, SqlParametros parametros)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataSet dataSet = new DataSet();
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				foreach (SqlParameter parametro in parametros.Parametros)
				{
					sqlCommand.Parameters.Add(parametro);
				}
				sqlDataAdapter.SelectCommand = sqlCommand;
				sqlDataAdapter.Fill(dataSet);
				return dataSet;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public DataTable ejecutarSpDatos(string nombreSp, SqlParametros parametros)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				foreach (SqlParameter parametro in parametros.Parametros)
				{
					sqlCommand.Parameters.Add(parametro);
				}
				sqlDataAdapter.SelectCommand = sqlCommand;
				sqlDataAdapter.Fill(dataTable);
				return dataTable;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public DataSet ejecutarSpDataSet(string nombreSp, SqlParametros parametros, ref int totalRegistros)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataSet dataSet = new DataSet();
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				foreach (SqlParameter parametro in parametros.Parametros)
				{
					sqlCommand.Parameters.Add(parametro);
				}
				sqlDataAdapter.SelectCommand = sqlCommand;
				sqlDataAdapter.Fill(dataSet);
				totalRegistros = Convert.ToInt32(sqlCommand.Parameters["@totalRegistros"].Value);
				return dataSet;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}

		public DataTable ejecutarSpDatos(string nombreSp, SqlParametros parametros, ref int totalRegistros)
		{
			_conexion = new SqlConnection(_cadenaConexion);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			try
			{
				_conexion.Open();
				SqlCommand sqlCommand = new SqlCommand(nombreSp, _conexion);
				sqlCommand.CommandType = CommandType.StoredProcedure;
				foreach (SqlParameter parametro in parametros.Parametros)
				{
					sqlCommand.Parameters.Add(parametro);
				}
				sqlDataAdapter.SelectCommand = sqlCommand;
				sqlDataAdapter.Fill(dataTable);
				totalRegistros = Convert.ToInt32(sqlCommand.Parameters["@totalRegistros"].Value);
				return dataTable;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
			finally
			{
				if (_conexion.State != 0)
				{
					_conexion.Close();
				}
			}
		}


	}
}
