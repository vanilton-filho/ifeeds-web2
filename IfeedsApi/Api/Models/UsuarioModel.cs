using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Api.Models
{
    /// <summary>Modelo de representação do usuário</summary>
    public class UsuarioModel
    {
        /// <summary>Matrícula do aluno ou servidor</summary>
        /// <example>20152863123456</example>
        [Required]
        public string Matricula { get; set; }

        /// <summary>Nome completo</summary>
        /// <example>Cicrano Fulano Beltrano da Silva</example>
        [Required]
        public string Nome { get; set; }

        /// <summary>Informações de contato do usuário</summary>
        public ContatoModel Contato { get; set; }

        /// <summary>Tipo de usuário</summary>
        /// <example>ADMIN</example>
        [Required]
        public string Role { get; set; }
    }


    /// <summary>Modelo de representação para a criação de um usuário</summary>
    public class UsuarioModelRequest
    {

        /// <summary>Matrícula do aluno ou servidor</summary>
        /// <example>20152863123456</example>
        [Required]
        public string Matricula { get; set; }

        /// <summary>Nome completo</summary>
        /// <example>Cicrano Fulano Beltrano da Silva</example>
        [Required]
        public string Nome { get; set; }

        /// <summary>Email válido</summary>
        /// <example>cicrano2@email.com</example>
        [Required]
        public string Email { get; set; }

        /// <summary>Telefone válido</summary>
        /// <example>79999999999</example>
        [Required]
        public string Telefone { get; set; }

        /// <summary>Senha do usuário</summary>
        /// <example>toor123</example>
        [Required]
        public string Senha { get; set; }
    }
}