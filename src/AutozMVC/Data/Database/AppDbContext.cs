using AutozMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AutozMVC.Data.Database;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

    }
    public DbSet<Car> Car { get; set; }
}