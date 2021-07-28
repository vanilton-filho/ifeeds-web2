using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Domain.Models 
{

    public class Campus
    {
        public Campus()
        {
           DataCriacao = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string Nome { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }


    }

}
