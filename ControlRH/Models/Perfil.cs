using System.Collections.Generic;

namespace ControlRH.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Role { get; set; }
    }

    public class PerfilViewModel
    {
        public int? Id { get; set; }
        public string Role { get; set; }
        public IEnumerable<Perfil> itensReturnToSelect { get; set; }
        public IEnumerable<Perfil> itensReturnToTable { get; set; }
        public IEnumerable<ControleAcesso> itensControleAcessos { get; set; }
        
    }
}