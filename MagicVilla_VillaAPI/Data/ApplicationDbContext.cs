using System;
using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
	public class ApplicationDbContext: DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Villa>().HasData(
                        new Villa
                        {
                            Id = 1,
                            Name = "Royal Villa",
                            Details = "Some desc",
                            ImageUrl = "https://atliq.com",
                            Sqft = 550,
                            Occupancy = 5,
                            Rate = 200,
                            Amenity = "",
                            CreatedDate=DateTime.Now
                        },
                        new Villa
                        {
                            Id = 2,
                            Name = "Diamond Villa",
                            Details = "Some desc",
                            ImageUrl = "https://atliq.com",
                            Sqft = 600,
                            Occupancy = 4,
                            Rate = 550,
                            Amenity = "",
                            CreatedDate = DateTime.Now
                        },
                        new Villa
                        {
                            Id = 3,
                            Name = "Diamond Pool Villa",
                            Details = "Some desc",
                            ImageUrl = "https://atliq.com",
                            Sqft = 1000,
                            Occupancy = 2,
                            Rate = 600,
                            Amenity = "",
                            CreatedDate = DateTime.Now
                        }
                );
		    }
	    }
}