using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class NivelAcesso
    {
        public int Id { get; set; }
        public int IdMenus { get; set; }
        public int IdNivelAcesso { get; set; }
        public int Acesso { get; set; }
    }

    public class NivelAcessoViewModel
    {
        public int Id { get; set; }
        public int IdMenus { get; set; }
        public int IdNivelAcesso { get; set; }
        public int Acesso { get; set; }
    }
}
