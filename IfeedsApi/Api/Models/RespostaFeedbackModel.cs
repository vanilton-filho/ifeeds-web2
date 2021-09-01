using AutoMapper;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Models
{
    [AutoMap(typeof(RespostaFeedback), ReverseMap = true)]
    public class RespostaFeedbackModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Nota { get; set; }
        public string Resposta { get; set; }
        public string Codigo { get; set; }
        public int FeedbackId { get; set; }
        public bool Status { get; set; }
        public string Usuario { get; set; }
    }

    [AutoMap(typeof(RespostaFeedback), ReverseMap = true)]
    public class RespostaFeedbackModelRequest
    {
        public string Resposta { get; set; }
        public int FeedbackId { get; set; }
        public int UsuarioId { get; set; }
    }

    [AutoMap(typeof(RespostaFeedback), ReverseMap = true)]
    public class RespostaFeedbackModelUpdateRequest
    {
        public string Resposta { get; set; }
    }
}