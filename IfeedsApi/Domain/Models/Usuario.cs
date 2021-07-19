using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Domain.Models
{
    public class Usuario
    {

        public Usuario()
        {
            DataCriacao = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Matricula { get; set; }

        [Required]
        [MaxLength(280)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(80)]
        public string Senha { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public int ContatoId { get; set; }

        public Contato Contato { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public ICollection<RespostaFeedback> RespostasFeedback { get; set; }

    }
}