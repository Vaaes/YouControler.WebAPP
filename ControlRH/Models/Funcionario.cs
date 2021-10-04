using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public string Salario { get; set; }
        public int IdCargo { get; set; }
    }

    public class FuncionarioViewModel
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public string Salario { get; set; }
        public int? IdCargo { get; set; }
        public IEnumerable<Funcionario> Itens { get; set; }
        public IEnumerable<Cargo> ItensCargoToselect { get; set; }
    }
}
