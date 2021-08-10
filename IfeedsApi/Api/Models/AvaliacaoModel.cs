using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Api.Models
{
    public class AvaliacaoModel
    {

        public string Titulo { get; set; }

        public decimal MediaAvaliacao { get; set; }

        public string Categoria { get; set; }

        public string Campus { get; set; }

        public int TotalFeedbacks { get; set; }
    }

    public class FeedbackAvaliacaoModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

    }
}
