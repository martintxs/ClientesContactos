using Model.Model.Contacto;
using Model.Model.Respuesta;
using System.Collections.Generic;

namespace Service.Contacto
{
    public interface IContactoService
    {
        (VoRespuesta, List<VoContacto>) ReadAll(VoContacto Contacto);
        (VoRespuesta, VoContacto) ReadId(int Id);
        VoRespuesta Save(VoContacto Contacto);
        VoRespuesta Delete(int Id);
    }
}
