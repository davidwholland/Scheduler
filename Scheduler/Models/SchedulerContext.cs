using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Scheduler.Models
{
    public class SchedulerContext : IdentityDbContext
    {
        public SchedulerContext() :
            base("Scheduler")
        {}

        public DbSet<Event> Events { get; set; }
        public DbSet<EventLog> EventLogs { get; set; }
    }
}