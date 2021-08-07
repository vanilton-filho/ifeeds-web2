using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IfeedsApi.Api.Models
{
    public class FormularioAvaliacaoModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }


    }
    public class FormularioAvaliacaoModelRequest 
    {
        [Required(ErrorMessage = "Título é um campo obrigatório")]
        [MaxLength(45)]
        public String Titulo{ get; set;}
        
        
        [Required(ErrorMessage = "Descrição é um campo obrigatório")]
        public String Descricao {get; set;}

        
        [Required(ErrorMessage = "Nota é um campo obrigatório")]
        [Range(0,5)]
        public decimal Nota{get; set;}



    }
}
