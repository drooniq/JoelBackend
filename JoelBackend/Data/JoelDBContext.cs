using JoelBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace JoelBackend.Data
{
    public class JoelDBContext : DbContext
    {
        public JoelDBContext(DbContextOptions<JoelDBContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
