using System;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhoWeb.Ecommerce.Domain.Entidades
{
    public class Usuario
    {
        public Usuario()
        {
            Erros = new List<string>();
        }

        public int Id { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; } 
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Perfil { get; set; }

        public List<string> Erros { get; set; }


        internal bool UsuarioInvalido()
        {
            if (string.IsNullOrEmpty(Senha))
                Erros.Add("Campo Senha obrigatório.");

            if (string.IsNullOrEmpty(Nome))
                Erros.Add("Campo Nome obrigatório.");

            if (string.IsNullOrEmpty(Cpf))
                Erros.Add("Campo Cpf obrigatório.");

            if (string.IsNullOrEmpty(Rg))
                Erros.Add("Campo Rg obrigatório.");

            if (string.IsNullOrEmpty(Telefone))
                Erros.Add("Campo Telefone obrigatório.");

            if (DateTime.MinValue.Equals(DataNascimento))
                Erros.Add("Campo Data de Nascimento obrigatório.");

            if (string.IsNullOrEmpty(Email))
                Erros.Add("Campo Email obrigatório.");

            if (string.IsNullOrEmpty(Endereco))
                Erros.Add("Campo Endereco obrigatório.");

            if (string.IsNullOrEmpty(Numero))
                Erros.Add("Campo Numero obrigatório.");

            if (string.IsNullOrEmpty(Complemento))
                Erros.Add("Campo Complemento obrigatório.");

            if (string.IsNullOrEmpty(Cidade))
                Erros.Add("Campo Cidade obrigatório.");

            if (string.IsNullOrEmpty(Bairro))
                Erros.Add("Campo Bairro obrigatório.");

            if (string.IsNullOrEmpty(Estado))
                Erros.Add("Campo Estado obrigatório.");

            if (string.IsNullOrEmpty(Cep))
                Erros.Add("Campo Cep obrigatório.");

            return Erros.Any();
        }
    }
}
