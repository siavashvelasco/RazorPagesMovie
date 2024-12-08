using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace razor.Model
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }

		[Range(0, 11,ErrorMessage ="range 1 till 11")]
		[DisplayName("Display order")]
		public int DisplayOrder { get; set; }
	}
}
