using Model.Model.Cliente;
using System.Data;

namespace Repository.Cliente
{
    public interface ICliente
    {
        DataSet ReadAll(VoCliente Cliente);
        DataSet ReadId(int Id);
        DataSet Save(VoCliente Cliente);
        DataSet Delete(int Id);
        DataSet Reporte(int Id);
    }
}
