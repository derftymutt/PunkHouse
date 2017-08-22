using System;
using Microsoft.EntityFrameworkCore;

namespace PunkHouse.Models.DbContexts
{
    public class HouseContext : DbContext
    {
        public HouseContext(DbContextOptions<HouseContext> options)
            : base(options)
        {
        }

        public DbSet<House> Houses { get; set; }
    }
}
