using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Country> Country { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Place> Place { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) //Responsible for creating migrations
    {

      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }

  }
}