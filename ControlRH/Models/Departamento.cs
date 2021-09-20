using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Departamento
    {
        public int ID { get; set; }
        public string NomeDepartamento { get; set; }
        public string GestorDepartamento { get; set; }
        public string Andar { get; set; }
        public string Sala { get; set; }
    }
}
