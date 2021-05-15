using Model.Model.Contacto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model.Cliente
{
    public class VoCliente
    {
        public int IdCliente { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string RFC { get; set; }
        public string CURP { get; set; }
        public string Direccion { get; set; }
        public List<VoContacto> Contactos { get; set; }
    }
}
