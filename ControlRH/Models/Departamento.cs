using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlRH.Models
{
    public class Departamento
    {
        public int ID { get; set; }
        public string NomeDepartamento { get; set; }
        public string GestorDepartamento { get; set; }
        public string Andar { get; set; }
        public string Sala { get; set; }
    }
    public class DepartamentoViewModel
    {
        public int ID { get; set; }
        public string NomeDepartamento { get; set; }
        public string GestorDepartamento { get; set; }
        public string Andar { get; set; }
        public string Sala { get; set; }
        public IEnumerable<Departamento> Itens { get; set; }
        public IEnumerable<Departamento> itensReturnToTable { get; set; }
        public IEnumerable<Departamento> itensReturnToSelect { get; set; }
        public IEnumerable<Funcionario> GestorReturnSelect { get; set; }

    }
}
