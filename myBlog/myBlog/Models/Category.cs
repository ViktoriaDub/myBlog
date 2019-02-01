using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myBlog.Models
{
	public class Category
	{
        public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public int ResponseId { get; set; }

	    public virtual Response Response { get; set; }
	}
}