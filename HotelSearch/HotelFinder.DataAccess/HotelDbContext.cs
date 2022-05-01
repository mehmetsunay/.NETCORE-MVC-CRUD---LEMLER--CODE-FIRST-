using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-H2G18BP\\SQLEXPRESS; Database=HotelDb; Trusted_Connection=true");

        }

        public DbSet<Hotel> Hotels { get; set; }

    }
        
    }

