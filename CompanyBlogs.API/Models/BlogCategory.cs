using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyBlogs.API.Models
{
	public class BlogCategory
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogCategoryId { get; set; }
		public string CategoryName { get; set; } = string.Empty;

		//many - many relation
		public virtual ICollection<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();

        public BlogCategory()
		{
		}
	}
}

