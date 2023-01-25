using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyBlogs.API.Models
{
	public class Metadata
	{
        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MetadataId { get; set; }

		public List<string> Tags { get; set; } = new List<string>();

        public Metadata()
		{
		}
	}
}

