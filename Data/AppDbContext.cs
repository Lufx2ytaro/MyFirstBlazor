using Microsoft.EntityFrameworkCore;
using Blazor.Models;

namespace Blazor.Data;

public class AppDbContext : DbContext
{
  public DbSet<Tariff> Tariffs { get; set; }

  public AppDbContext(DbContextOptions<AppDbContext> options)
  : base(options) { }
}