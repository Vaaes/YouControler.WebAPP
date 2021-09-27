using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Permissoes
    {
        public int Id { get; set; }
        public int IdMenu { get; set; }
        public int IdPerfilAcesso { get; set; }
        public int CRIAR { get; set; }
        public int LER { get; set; }
        public int ALTERAR { get; set; }
        public int DELETAR { get; set; }
    }

    public class PermissoesViewModel
    {
        public int Id { get; set; }
        public int IdMenu { get; set; }
        public int IdPerfilAcesso { get; set; }
        public int CRIAR { get; set; }
        public int LER { get; set; }
        public int ALTERAR { get; set; }
        public int DELETAR { get; set; }

        public IEnumerable<Permissoes> Itens { get; set; }
    }
}
