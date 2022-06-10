using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace crudDroup.Models
{
    public class DbConnection:DbContext
    {
        public DbConnection(DbContextOptions<DbConnection> options) : base(options) { }
        public DbSet<Employee> employees { get; set; }
        public DbSet<country> countries { get; set; }
        public DbSet<state> states { get; set; }
        public DbSet<City> cities { get; set; }
    }
}
