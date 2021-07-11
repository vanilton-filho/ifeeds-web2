using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Domain.Models 
{

    public class Campus
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DataAtualizacao { get; set; }


        public ICollection<FormularioAvaliacao> FormulariosAvaliacoes {get; set;}

    }

}
