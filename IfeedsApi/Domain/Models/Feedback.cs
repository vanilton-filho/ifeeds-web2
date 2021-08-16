using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
            Status = false;
        }


        [Key]
        public int Id { get; set; }

        [Required]
        public Guid Codigo { get; set; }

         [Required]
        [MaxLength(45)]
        public string Titulo { get; set; }


        [Required]
        public string Descricao { get; set; }


        [Required]
        [Column(TypeName = "decimal(5,1)")]
        public decimal Nota { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

        public RespostaFeedback RespostasFeedback { get; set; }

        public int AvaliacaoId{get; set;}

        public Avaliacao Avaliacao {get; set;}

    }
}
