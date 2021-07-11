using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace IfeedsApi.Domain.Models {

    public class RespostaFeedback {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Resposta { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set; }

        public int FeedbackId { get; set; }

        public Feedback Feedback { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

    }

}