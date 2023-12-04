using Microsoft.EntityFrameworkCore;
using Tarea3.Models;

namespace Tarea3.Data
{
    public class AsignaturaContext : DbContext
    {

        public AsignaturaContext(DbContextOptions<AsignaturaContext> options) : base(options) { }
        public DbSet<Asignatura> Asignaturas { get; set; }
    }
}
