using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Ferias
    {
        public int Id { get; set; }
        public string Data_Inicio { get; set; }
        public string Data_Final { get; set; }
        public int IdUsuario { get; set; }
        public bool Aprovado { get; set; }
        public string Nome { get; set; }
    }

    public class FeriasViewModel
    {
        public int? Id { get; set; }
        public string Data_Inicio { get; set; } = "";
        public string Data_Final { get; set; } = "";
        public int? IdUsuario { get; set; }
        public bool? Aprovado { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Ferias> Itens { get; set; }
    }
}
