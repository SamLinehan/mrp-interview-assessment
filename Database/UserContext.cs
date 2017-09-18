using System;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=assessment;User ID=sa;Password=Password!");
		}
    }
}
