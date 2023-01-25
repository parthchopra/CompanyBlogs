using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyBlogs.API.Models
{
	public class Blog
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; }


        public string BlogName { get; set; } = string.Empty;

        //many - many relation
        public virtual ICollection<BlogPost> BlogPosts { get; set; } = new List<BlogPost>();

        public Blog()
		{
		}
	}
}

