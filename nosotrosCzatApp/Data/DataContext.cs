using Microsoft.EntityFrameworkCore;
using nosotrosCzatApp.Models;

namespace nosotrosCzatApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
        
    }
}