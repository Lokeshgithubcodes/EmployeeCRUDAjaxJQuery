using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        
        public DbSet<Employee> Employees { get; set; }
    }
}
