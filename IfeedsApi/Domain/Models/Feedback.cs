using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Domain.Models
{
    public class Feedback
    {
        public Feedback()
        {
            DataCriacao = DateTime.UtcNow;
            Codigo = Guid.NewGuid();
        }


        [Key]
        public int Id { get; set; }

        [Required]
        public Guid Codigo { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public int AvaliacaoId { get; set; }

        public Avaliacao Avaliacao { get; set; }

        public int FormularioAvaliacaoId { get; set; }

        public FormularioAvaliacao FormularioAvaliacao { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public RespostaFeedback RespostasFeedback { get; set; }

    }
}
