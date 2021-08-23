namespace IfeedsApi.Api.Models
{
    public class RespostaFeedbackModel
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Nota { get; set; }
        public string Resposta { get; set; }
        public bool Status { get; set; }
        public string Usuario { get; set; }
    }

    public class RespostaFeedbackModelRequest
    {
        public string Resposta { get; set; }
        public int FeedbackId { get; set; }
        public int UsuarioId { get; set; }
    }

    public class RespostaFeedbackModelUpdateRequest
    {
        public string Resposta {get; set;}
    }
}