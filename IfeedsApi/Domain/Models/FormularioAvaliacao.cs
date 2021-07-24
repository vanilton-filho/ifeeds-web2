using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IfeedsApi.Domain.Models
{
    public class FormularioAvaliacao
    {

        public FormularioAvaliacao()
        {
            DataCriacao = DateTime.UtcNow;
        }


        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Titulo { get; set; }


        [Required]
        public string Descricao { get; set; }


        [Required]
        [Column(TypeName = "decimal(5,1)")]
        public decimal QuantidadeEstrelas { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }


        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set; }

        public Feedback Feedback { get; set; }

        public ICollection<Campus> Campus { get; set; }

    }

}
