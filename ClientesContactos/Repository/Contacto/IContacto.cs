using Model.Model.Contacto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contacto
{
    public interface IContacto
    {
        DataSet ReadAll(int Id);
        DataSet ReadId(int Id);
        DataSet Save(VoContacto Contacto);
        DataSet Delete(int Id);
    }
}
