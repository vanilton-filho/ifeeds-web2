using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DataAtualizacao { get; set; }

        public int ContatoId { get; set; }

        [JsonIgnore]
        public Contato Contato { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }

        public ICollection<RespostaFeedback> RespostasFeedback { get; set; }

    }
}