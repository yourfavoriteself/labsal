using System;

using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

using RazorModels;

namespace RazorServices
{
	public class AppDbContext : DbContext
	{
		public DbSet<City> City { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Sight> Sight { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Data Source=localhost; Initial Catalog=lab12; User Id=sa; Password=MyStr0ngPassword!;"); // TODO
        }
    }
}

