using System.ComponentModel.DataAnnotations;
using AutoMapper;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Api.Models
{
    [AutoMap(typeof(Role), ReverseMap =true)]
    public class RoleModel
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

    }

    [AutoMap(typeof(Role), ReverseMap =true)]
    public class RoleModelRequest
    {
        [MaxLength(20)]
        [Required(ErrorMessage = "Tipo é um campo obrigatório")]
        public string Tipo { get; set;}
    }
}