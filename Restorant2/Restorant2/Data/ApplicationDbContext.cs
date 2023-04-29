using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restorant2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restorant2.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<Category>Categories { get; set; }
		public DbSet<Menu>Menuler { get; set; }
		public DbSet<Rezervasyon>Rezervasyonlar { get; set; }
		public DbSet<Galeri>Galeriler { get; set; }
		public DbSet<Hakkımızda>hakkımızdas { get; set; }
		public DbSet<Blog>Blogs { get; set; }
		public DbSet<Iletisim>Iletisims { get; set; }
		public DbSet<Iletisimim>Iletisimims { get; set; }
		public DbSet<AppUser>AppUsers { get; set; }


	}
}
