using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Ferias
    {
        public int Id { get; set; }
        public DateTime Data_Inicio { get; set; }
        public DateTime Data_Final { get; set; }
        public int IdUsuario { get; set; }
        public bool Aprovado { get; set; }
    }
}
