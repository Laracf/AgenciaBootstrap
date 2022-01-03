using System;
using System.ComponentModel.DataAnnotations;

namespace Agencia.Models
{
    public class Destino
    {
        [Key]
        [Required]
        public int IdDestino {get; set;}
        
        [Required]
        public string NomeDestino {get;set;}


    }
}