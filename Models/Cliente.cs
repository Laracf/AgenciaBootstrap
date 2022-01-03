using System;
using System.ComponentModel.DataAnnotations;

namespace Agencia.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int IdCliente {get; set;}
        
        [Required]
        public string NomeCliente {get;set;}
    }
}