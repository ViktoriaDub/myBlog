using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myBlog.Models
{
	public class Response
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Image { get; set; }
		public string Text { get; set; }
		public int Year { get; set; }
		public string Country { get; set; }
		public string Quality { get; set; }
		public string Translation { get; set; }
		public int Duration { get; set; }
		[DisplayName("Start Date")]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
		public DateTime Premiere { get; set;}
        public string Director { get; set; }
		public virtual IList<Category> Categories { get; set; }
    }
}


		

