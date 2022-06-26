using AvaliadorDeCredito.Models;
using Microsoft.EntityFrameworkCore;

namespace AvaliadorDeCredito.DataBase
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            :base(options) => Database.EnsureCreated();

        public DbSet<Cliente> Cliente { get; set; }
      
    }
}
