using Microsoft.EntityFrameworkCore;
using Tarea3.Models;

namespace Tarea3.Data
{
    public class LoginContext : DbContext
    {

        public LoginContext(DbContextOptions<LoginContext> options) : base(options) { }
        public DbSet<Login> Logins { get; set; }

    }
}
