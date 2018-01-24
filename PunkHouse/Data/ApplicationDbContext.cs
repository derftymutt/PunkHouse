using System;
using Microsoft.EntityFrameworkCore;
using PunkHouse.Models;

namespace PunkHouse.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<House> Houses { get; set; }
    }
}
