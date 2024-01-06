using Microsoft.EntityFrameworkCore;
using LeThiMaiAnh076.Models;
using LeThiMaiAnh076;

namespace LeThiMaiAnh076.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<LeThiMaiAnh> LeThiMaiAnh {get;set;}
    }
}