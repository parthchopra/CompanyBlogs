using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CompanyBlogs.API.Models
{
	public class BlogDbContext : DbContext
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
		{

		}

		public DbSet<Blog> Blogs { get; set; } = default!;
		public DbSet<BlogCategory> BlogCategories { get; set; } = default!;
		public DbSet<BlogPost> BlogPosts { get; set; } = default!;
        public DbSet<Metadata> Metadata { get; set; } = default!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Metadata>().Property(p => p.Tags)
				.HasConversion(
					v => string.Join(',', v),
					v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList());
        } 
    }
}

