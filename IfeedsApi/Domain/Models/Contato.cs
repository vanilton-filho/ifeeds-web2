using System;
using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Domain.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        [EmailAddress(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        [Phone(ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set; }

        public Usuario Usuario { get; set; }

    }
}