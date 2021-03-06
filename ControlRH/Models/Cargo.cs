using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Cargo
    {
        public int ID { get; set; }
        public string Nome_Cargo { get; set; }
        public string Descricao_Cargo { get; set; }
    }

    public class CargoViewModel
    {
        public int? ID { get; set; }
        public string Nome_Cargo { get; set; }
        public string Descricao_Cargo { get; set; }

        public IEnumerable<Cargo> Itens { get; set; }
        public IEnumerable<Cargo> ItensToSelect { get; set; }
    }
}
