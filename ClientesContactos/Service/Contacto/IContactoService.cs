using Model.Model.Contacto;
using Model.Model.Respuesta;
using System.Collections.Generic;

namespace Service.Contacto
{
    public interface IContactoService
    {
        (VoRespuesta, List<VoContacto>) ReadAll(int Id);
        (VoRespuesta, VoContacto) ReadId(int Id);
        VoRespuesta Save(VoContacto Contacto);
        VoRespuesta Delete(int Id);
    }
}
