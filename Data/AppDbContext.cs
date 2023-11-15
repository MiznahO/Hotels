using Hotels.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cart> cart {  get; set; }
        public DbSet<Hotles> hotles { get; set; }
        public DbSet<Invoice> invoice { get; set; }
        public DbSet<RoomDetails> roomDetails { get; set; }
        public DbSet<Rooms> rooms { get; set; }
    }
}
