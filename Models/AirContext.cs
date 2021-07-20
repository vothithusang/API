using AirLineAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class AirContext : DbContext
    {
        public AirContext(DbContextOptions<AirContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Course>().ToTable("Course");
            //modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            //modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Flight>()
            .HasKey(o => new { o.LocationTo, o.Location, o.StartTime, o.Flight_ID});
        }
        // The following configures EF to create a Sqlite database file as `C:\blogging.db`.
        // For Mac or Linux, change this to `/tmp/blogging.db` or any other absolute path.
        public DbSet<FlightRoute> FlightRoutes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<DetailTicket> Detailtickets { get; set; }
        public DbSet<TicketsSold> TicketsSolds { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }

    }
}
