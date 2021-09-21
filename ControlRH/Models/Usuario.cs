using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public string Telefone_Celular { get; set; }
        public string Telefone_Residencial { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
        public string token { get; set; }
    }
}
