using System;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=ZEK\SQLEXPRESS01; Database=HotelDb; Trusted_Connection=True");
        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
