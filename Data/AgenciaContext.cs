using System;
using Agencia.Models;
using Microsoft.EntityFrameworkCore;

namespace Agencia.Data
{
    public class AgenciaContext : DbContext
    {
        public AgenciaContext(DbContextOptions<AgenciaContext> opt) : base(opt)
        {
        }
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Agencia.Models.Destino> Destinos { get; set; }
        public DbSet<Agencia.Models.Compra> Compras { get; set; }
    }
}