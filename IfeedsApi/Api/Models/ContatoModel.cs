using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Api.Models
{
    /// <summary>Modelo de representação de contato</summary>
    public class ContatoModel
    {
        /// <summary>Email válido</summary>
        /// <example>cicrano@email.com</example>
        [Required]
        public string Email { get; set; }

        /// <summary>Telefone válido</summary>
        /// <example>79999999999</example>
        [Required]
        public string Telefone { get; set; }
    }
}