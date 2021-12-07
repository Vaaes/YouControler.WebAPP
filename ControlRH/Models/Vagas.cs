using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Vagas
    {
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public string DataMaxima { get; set; }
        public string PerfilVaga { get; set; }
    }

    public class VagasViewModel
    {
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public string DataMaxima { get; set; }
        public string PerfilVaga { get; set; }
        public IEnumerable<Vagas> Itens { get; set; }
    }
}
