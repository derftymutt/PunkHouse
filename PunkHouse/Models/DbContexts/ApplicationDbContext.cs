using System;
using Microsoft.EntityFrameworkCore;

namespace PunkHouse.Models.DbContexts
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
