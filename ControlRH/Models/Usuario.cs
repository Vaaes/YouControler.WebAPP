using System;
using System.Collections.Generic;

namespace ControlRH.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdNivelAcesso { get; set; }
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

    public class UsuarioViewModel
    {
        public int? Id { get; set; }
        public int? IdNivelAcesso { get; set; }
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
        public IEnumerable<Usuario> Itens { get; set; }
        public IEnumerable<Perfil> ItensToPerfilSelect { get; set; }
    }
}
