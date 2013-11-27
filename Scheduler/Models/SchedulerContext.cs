using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Scheduler.Models
{
    public class SchedulerContext : DbContext
    {
        public SchedulerContext() :
            base("Scheduler")
        {}

        public DbSet<Event> Events { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}