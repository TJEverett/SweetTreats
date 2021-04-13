using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetTreats.Models
{
  public class SweetTreatsContext : IdentityDbContext<ApplicationUser>
  {


    public SweetTreatsContext(DbContextOptions options) : base(options) { }
  }
}