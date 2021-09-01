using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Models
{
    [AutoMap(typeof(Feedback), ReverseMap = true)]
    [AutoMap(typeof(Usuario), ReverseMap = true)]
    public class FeedbackModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Matricula { get; set; }

        public decimal Nota { get; set; }

        public FeedbackAvaliacaoModel Avaliacao { get; set; }


        public string Campus { get; set; }

        public string Resposta { get; set; }

        public bool Status { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataResposta { get; set; }

    }

    [AutoMap(typeof(Feedback), ReverseMap = true)]
    public class FeedbaackModelRequest
    {
        [Required(ErrorMessage = "Título é um campo obrigatório")]
        [MaxLength(45)]
        public String Titulo { get; set; }


        [Required(ErrorMessage = "Descrição é um campo obrigatório")]
        public String Descricao { get; set; }


        [Required(ErrorMessage = "Nota é um campo obrigatório")]
        [Range(0, 5)]
        public decimal Nota { get; set; }


        public int AvaliacaoId { get; set; }

        public int UsuarioId { get; set; }

    }
}
