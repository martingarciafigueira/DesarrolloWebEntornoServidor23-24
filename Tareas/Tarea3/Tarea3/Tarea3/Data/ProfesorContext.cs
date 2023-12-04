using Microsoft.EntityFrameworkCore;
using Tarea3.Models;

namespace Tarea3.Data
{
    public class ProfesorContext : DbContext
    {

        public ProfesorContext(DbContextOptions<ProfesorContext> options) : base(options) { }
        public DbSet<Profesor> Profesores { get; set; }

    }
}
