using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Api.Models
{
    /// <summary>Modelo de representação de contato</summary>
    public class ContatoModel
    {
        public int Id {get;set;}

        /// <summary>Email válido</summary>
        /// <example>cicrano@email.com</example>
        [Required]
        public string Email { get; set; }

        /// <summary>Telefone válido</summary>
        /// <example>79999999999</example>
        [Required]
        public string Telefone { get; set; }
    }

    public class ContatoModelRequest
    {
        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "O email informado não é válido")]
        public string Email {get; set;}


        [Required(ErrorMessage = "Telefone é um campo obrigatório")]
        [MaxLength(11)] // tamanho de um número considerando o padrão brasileiro
        [MinLength(11)]
        [Phone(ErrorMessage = "O telefone informado não é válido")]
        public string Telefone {get; set;}
    }
}