using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyBlogs.API.Models
{
	public class BlogPost
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BlogPostId { get; set; }

		[Required(ErrorMessage = "Please enter the blog post title")]
		[StringLength(100)]
		public string Title { get; set; } = string.Empty;

		public Metadata Metadata { get; set; } = new Metadata();

		[Required(ErrorMessage = "Please upload a cover picture for the blog")]
        [StringLength(255)]
        public string CoverPictureUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a short introduction for the blog")]
        [StringLength(255)]
        public string ShortIntroduction { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a description for the blog")]        
        public string Description { get; set; } = string.Empty;

		public bool IsActive { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }

		// Many - Many relations
		public virtual ICollection<Blog> Blogs { get; set; } = new List<Blog>();
		public virtual ICollection<BlogCategory> Categories { get; set; } = new List<BlogCategory>();

        public BlogPost()
		{
		}
	}
}

