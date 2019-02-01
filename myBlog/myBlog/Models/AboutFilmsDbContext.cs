using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace myBlog.Models
{
	public class AboutFilmsDbContext : DbContext
	{
		public AboutFilmsDbContext() : base("CategoryContext")
		{

		}
		public DbSet<Category> Categories { get; set; }
		public DbSet<Response> Responses { get; set; }
	}
}