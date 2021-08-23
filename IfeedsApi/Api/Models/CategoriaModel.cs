using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Api.Models
{
    public class CategoriaModel
    {

        public int Id { get; set; }
        public string Nome { get; set; }

    }

    public class CategoriaModelRequest
    {
        [MaxLength(20)]
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
       public string Nome{get;set;}
    }
}
