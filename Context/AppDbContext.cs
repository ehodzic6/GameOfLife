using GameOfLife.Models;
using Microsoft.EntityFrameworkCore;

namespace GameOfLife.Context
{
    public class AppDbContext : DbContext
    {
        DbSet<Human> Humans { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=gameOfLife.db");
        }

    }
}
