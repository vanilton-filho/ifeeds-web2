using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IfeedsApi.Domain.Models
{
    public class Avaliacao
    {

        public Avaliacao()
        {
            DataCriacao = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Titulo { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,1)")]
        public decimal MediaAvaliacao { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public int CampusId { get; set; }

        public Campus Campus { get; set; }

        public ICollection<Feedback> Feedbacks {get; set;}


    }
}
