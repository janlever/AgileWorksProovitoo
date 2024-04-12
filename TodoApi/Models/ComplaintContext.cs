using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ComplaintContext : DbContext
    {
        public ComplaintContext(DbContextOptions<ComplaintContext> options) : base(options)
        {

        }

        public DbSet<Application> Applications { get; set; }
    }
}