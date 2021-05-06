using MySql.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
	public class BibliotekaDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySQL("server=localhost;database=3PL1_Biblioteka;UId=root;password=root");
		}

		public DbSet<Kategorija> Kategorijos { get; set; }

		public DbSet<Klientas> Klientai { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Kategorija>(entity => {
				entity.Property(m => m.AmžiausCenzūra).HasColumnName("AmziausCenzura").HasMaxLength(50);
				entity.HasKey(m => m.Id);
				entity.Property(m => m.Id).ValueGeneratedOnAdd();
			});
		}
	}
}