using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Api.Models
{
    public class FeedbackModel
    {
        public string Codigo { get; set; }

        public FormularioAvaliacaoModel Formulario { get; set; }

        public string Matricula { get; set; }

        public decimal Nota { get; set; }

        public FeedbackAvaliacaoModel Avaliacao { get; set; }

        public string Campus { get; set; }

        public string Resposta { get; set; }

        public bool Status { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime? DataResposta { get; set; }

    }
}
