using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace Agencia.Models
{
    public class Compra
    {
         [Key]
       [Required]
       public int IdCompra {get; set;} 
       
       [StringLength(10)]
       [Required]
       public string DataIda {get; set;}
    
       [StringLength(10)]
       [Required]
       public string DataVolta {get; set;}
       
       [Required]
       public int valor {get;set;}
       
       [Required]
       public int FK_IdCliente {get; set;}
       public Cliente Cliente {get; set;}

       [Required]
       public int FK_IdDestino {get; set;}
       public Destino Destino {get; set;}
       
    }
}