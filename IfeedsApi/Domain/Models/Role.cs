using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace IfeedsApi.Domain.Models {

    public class Role { 
        
        [Key]
        public int Id { get; set;}

        [Required]
        [MaxLength(20)]
        public string Tipo { get; set;}


        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCriacao { get; set;}

        
        [DataType(DataType.DateTime)]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? DataAtualizacao { get; set;}

        public ICollection<Usuario> Usuario { get; set; }

        
    }
}