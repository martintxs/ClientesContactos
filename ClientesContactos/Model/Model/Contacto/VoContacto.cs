using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model.Contacto
{
    public class VoContacto
    {
        public int IdContacto { get; set; }
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Puesto { get; set; }
    }
}
