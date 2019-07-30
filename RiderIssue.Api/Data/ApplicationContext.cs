using Microsoft.EntityFrameworkCore;

namespace RiderIssue.Api.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}
