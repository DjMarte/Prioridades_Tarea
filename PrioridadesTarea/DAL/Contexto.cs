using Microsoft.EntityFrameworkCore;
using PrioridadesTarea.Models;

namespace PrioridadesTarea.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Prioridades> Prioridades { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { 

        }
    }
}
