using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace IfeedsApi.Domain.Models {

    public class RespostaFeedback {

        public RespostaFeedback()
        {
            DataCriacao = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Resposta { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public int FeedbackId { get; set; }

        public Feedback Feedback { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

    }

}