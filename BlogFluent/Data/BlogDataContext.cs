using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogFluent.Data.Mappings;
using BlogFluent.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
  public class BlogDataContext : DbContext
  {

    public DbSet<Category> Categories { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
      => options.UseSqlServer("Server=localhost,1433;Database=BlogFluentMap;User ID=sa;  Password=#Davi2505;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new CategoryMap());
      modelBuilder.ApplyConfiguration(new UserMap());
      modelBuilder.ApplyConfiguration(new PostMap());
    }

  }
}