using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IfeedsApi.Domain.Models
{
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(45)]
        public string Titulo { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal MediaAvaliacao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }

    }
}
