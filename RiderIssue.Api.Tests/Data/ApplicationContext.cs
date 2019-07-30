using Microsoft.EntityFrameworkCore;
using RiderIssue.Api.Tests.Environment;
using RiderIssue.Api.Tests.Model.Db;

namespace RiderIssue.Api.Tests.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        
        public ApplicationContext() : base(
            new DbContextOptionsBuilder<ApplicationContext>().UseNpgsql(
                $"Host={new AppHost().Value()};Port=5432;Database=rider_db;Username=rider_user;Password=rider_password"
            ).Options
        ) { }
    }
}
