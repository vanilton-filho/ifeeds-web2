using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IfeedsApi.Domain.Models 
{
    public class FormularioAvaliacao 
    {

        [Key]
        public int Id { get; set; }


        [Required]
        public string Descricao { get; set; }


        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal QuantidadeEstrelas { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao {get; set;}


        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set;}

        public Feedback Feedback { get; set; }

        public ICollection<Campus> Campus { get; set; }
 
    }

}
