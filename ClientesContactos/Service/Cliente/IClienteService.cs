using Model.Model.Cliente;
using Model.Model.Respuesta;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Service.Cliente
{
    public interface IClienteService
    {
        (VoRespuesta,List<VoCliente>) ReadAll(VoCliente Cliente);
        (VoRespuesta, VoCliente) ReadId(int Id);
        VoRespuesta Save(VoCliente Cliente);
        VoRespuesta Delete(int Id);
        (VoRespuesta, byte[]) Reporte(int Id);
    }
}
