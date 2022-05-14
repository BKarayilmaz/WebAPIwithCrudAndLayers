using HotelFinder.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.DataAccess
{
    class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-QVNJVT9\\SQLEXPRESS; database=HotelDb; integrated security=true");
        }

        public DbSet<Hotel> Hotels { get; set; }

    }
}
