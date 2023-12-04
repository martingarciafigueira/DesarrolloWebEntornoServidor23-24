using Microsoft.EntityFrameworkCore;
using Tarea3.Models;

namespace Tarea3.Data
{
    public class EstudianteContext : DbContext
    {

        public EstudianteContext(DbContextOptions<EstudianteContext> options) : base(options) { }
        public DbSet<Estudiante> Estudiantes { get; set; }

    }
}
