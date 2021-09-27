using System.Collections.Generic;

namespace ControlRH.Models
{
    public class ControleAcesso
    {
        public int Id { get; set; }
        public string Menu { get; set; }
        public int IdAcesso { get; set; }
    }

    public class ControleAcessoViewModel
    {
        public int Id { get; set; }
        public string Menu { get; set; }
        public int IdAcesso { get; set; }

        public IEnumerable<ControleAcesso> Itens { get; set; }
    }
}
