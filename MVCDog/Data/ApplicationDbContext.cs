using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCDog.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using MVCDog.Models;

namespace MVCDog.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet <Dog> Dogs { get; set; }
        public DbSet<GuineaPig> GuineaPigs { get; set; }
   
    }
}
