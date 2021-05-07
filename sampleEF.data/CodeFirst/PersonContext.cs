using System;
using Microsoft.EntityFrameworkCore;

namespace sampleEF.data.CodeFirst
{
  public class PersonContext : DbContext
  {
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("Data Source=mssql;Initial Catalog=testdb;User ID=sa;Password='cJ3\"fC7>oN3;iN4>';");
      }
    }
  }
}