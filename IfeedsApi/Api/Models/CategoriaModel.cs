using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Models
{
    [AutoMap(typeof(Categoria), ReverseMap = true)]
    public class CategoriaModel
    {

        public int Id { get; set; }
        public string Nome { get; set; }

    }

    [AutoMap(typeof(Categoria), ReverseMap = true)]
    public class CategoriaModelRequest
    {
        [MaxLength(20)]
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
       public string Nome{get;set;}
    }
}
