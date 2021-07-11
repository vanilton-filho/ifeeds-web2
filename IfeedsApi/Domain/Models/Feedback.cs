using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Domain.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(36)]
        public string Codigo { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set; }

        public int AvaliacaoId { get; set; }

        public Avaliacao Avaliacao { get; set; }

        public int FormularioAvaliacaoId { get; set; }

        public FormularioAvaliacao FormularioAvaliacao { get; set; }

        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }

    }
}
