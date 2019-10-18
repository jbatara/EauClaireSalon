using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class SalonContext : DbContext
  {
    public virtual DbSet<Stylist> Cuisine { get; set; }
    public virtual DbSet<Client> Restaurants { get; set; }


    public SalonContext(DbContextOptions options) : base(options){}
  }
}