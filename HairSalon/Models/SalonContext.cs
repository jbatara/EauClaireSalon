using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Service> Services {get;set;}
    public virtual DbSet<Appointment> Appointments {get;set;}


    public SalonContext(DbContextOptions options) : base(options){}
  }
}