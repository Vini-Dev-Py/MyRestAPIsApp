using Microsoft.EntityFrameworkCore;

namespace MyRestCarnes.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {}

        public DbSet<Store> Shops { get; set; }
    }
}