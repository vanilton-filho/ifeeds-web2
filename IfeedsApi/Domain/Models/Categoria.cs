using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Domain.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set; }
        public ICollection<Avaliacao> Avaliacoes { get; set; }
    }
}