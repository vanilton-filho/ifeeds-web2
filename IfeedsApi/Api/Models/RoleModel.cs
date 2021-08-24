using System.ComponentModel.DataAnnotations;

namespace IfeedsApi.Api.Models
{
    public class RoleModel
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

    }

    public class RoleModelRequest
    {
        [MaxLength(20)]
        [Required(ErrorMessage = "Tipo é um campo obrigatório")]
        public string Tipo { get; set;}
    }
}