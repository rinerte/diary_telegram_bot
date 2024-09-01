using Microsoft.EntityFrameworkCore;
using DataLayer.Models;

namespace DataLayer
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
        : base(options)
        {
           //Database.EnsureDeleted();
           Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}