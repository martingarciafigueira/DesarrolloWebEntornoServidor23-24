using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace Ejercicio1.Models
{
    public class FabricanteContext : DbContext
    {
        public FabricanteContext(DbContextOptions<FabricanteContext> options) : base(options)
        { }
        public DbSet<Fabricante> Fabricante { get; set; }
    }
}
