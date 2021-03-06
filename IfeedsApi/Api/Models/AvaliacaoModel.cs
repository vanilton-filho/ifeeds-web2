using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Models
{
    [AutoMap(typeof(Avaliacao), ReverseMap = true)]
    public class AvaliacaoModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public decimal MediaAvaliacao { get; set; }

        public CategoriaModel Categoria { get; set; }

        public CampusModel Campus { get; set; }

        public int TotalFeedbacks { get; set; }
    }

    [AutoMap(typeof(Avaliacao), ReverseMap = true)]
    public class FeedbackAvaliacaoModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

    }

    [AutoMap(typeof(Avaliacao), ReverseMap = true)]
    public class AvaliacaoModelRequest
    {
        [MaxLength(45)]
        [Required(ErrorMessage = "Título é um campo obrigatório")]
        public string Titulo { get; set; }


        [Required(ErrorMessage = "Título é um campo obrigatório")]
        public int CategoriaId { get; set; }


        [Required(ErrorMessage = "Título é um campo obrigatório")]
        public int CampusId { get; set; }

    }
}
