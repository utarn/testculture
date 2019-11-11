using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace testcultureinfo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Sample> Samples { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class Sample
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
