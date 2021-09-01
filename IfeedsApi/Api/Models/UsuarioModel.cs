using System.ComponentModel.DataAnnotations;
using AutoMapper;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Models
{
    /// <summary>Modelo de representação do usuário</summary>
    [AutoMap(typeof(Usuario), ReverseMap = true)]
    public class UsuarioModel
    {
        /// <summary>Id do aluno ou servidor</summary>
        /// <example>1</example>
        public int Id { get; set; }

        /// <summary>Matrícula do aluno ou servidor</summary>
        /// <example>20152863123456</example>
        public string Matricula { get; set; }

        /// <summary>Nome completo</summary>
        /// <example>Cicrano Fulano Beltrano da Silva</example>
        public string Nome { get; set; }

        /// <summary>Informações de contato do usuário</summary>
        public ContatoModel Contato { get; set; }

        /// <summary>Tipo de usuário</summary>
        /// <example>ADMIN</example>
        public string Role { get; set; }

        public bool Status { get; set; }

        public string Campus { get; set; }
    }


    /// <summary>Modelo de representação para a criação de um usuário</summary>
    [AutoMap(typeof(Usuario), ReverseMap = true)]
    [AutoMap(typeof(Contato), ReverseMap = true)]
    [AutoMap(typeof(Campus), ReverseMap = true)]
    public class UsuarioModelRequest
    {

        /// <summary>Matrícula do aluno ou servidor</summary>
        /// <example>20152863123456</example>
        [Required(ErrorMessage = "Matrícula é um campo obrigatório")]
        public string Matricula { get; set; }

        /// <summary>Nome completo</summary>
        /// <example>Cicrano Fulano Beltrano da Silva</example>
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        public string Nome { get; set; }

        /// <summary>Email válido</summary>
        /// <example>cicrano2@email.com</example>
        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "O email informado não é válido")]
        public string Email { get; set; }

        /// <summary>Telefone válido</summary>
        /// <example>79999999999</example>
        [Required(ErrorMessage = "Telefone é um campo obrigatório")]
        [MaxLength(11)] // tamanho de um número considerando o padrão brasileiro
        [MinLength(11)]
        [Phone(ErrorMessage = "O telefone informado não é válido")]
        public string Telefone { get; set; }

        /// <summary>Senha do usuário</summary>
        /// <example>toor123</example>
        [Required(ErrorMessage = "Senha é um campo obrigatório")]
        [MinLength(8, ErrorMessage = "A senha precisa ter no mínimo 8 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O id do Campus é obrigatório")]
        public int CampusId { get; set; }

        [Required(ErrorMessage = "O tipo de conta é obrigatório")]
        public int TipoConta { get; set; }
    }

    /// <summary>Modelo de representação para a atualização de um usuário</summary>
    [AutoMap(typeof(Usuario), ReverseMap = true)]
    public class UsuarioUpdateModelRequest
    {
        /// <summary>Matrícula do aluno ou servidor</summary>
        /// <example>20152863123456</example>
        [Required(ErrorMessage = "Matrícula é um campo obrigatório")]
        public string Matricula { get; set; }

        /// <summary>Nome completo</summary>
        /// <example>Cicrano Fulano Beltrano da Silva</example>
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        public string Nome { get; set; }
    }

    /// <summary>Modelo de representação para login do usuário</summary>
    public class LoginModelRequest
    {
        /// <summary>Matrícula do aluno ou servidor</summary>
        /// <example>20152863123456</example>
        [Required(ErrorMessage = "Matrícula é um campo obrigatório")]
        public string Matricula { get; set; }

        /// <summary>Senha do usuário</summary>
        /// <example>toor123</example>
        [Required(ErrorMessage = "Senha é um campo obrigatório")]
        public string Senha { get; set; }

    }

    public class AlterarSenhaModel
    {
        [Required(ErrorMessage = "Senha atual é um campo obrigatório")]
        public string senhaAtual { get; set; }

        [Required(ErrorMessage = "Nova senha é um campo obrigatório")]
        public string novaSenha { get; set; }

    }
}