using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20,ErrorMessage ="max is 20")]
        public string Name { get; set; }
        

        [Range(1,5,ErrorMessage ="out of range")]
        [DisplayName("Display order")]
        public int DisplayOrder { get; set; }
    }
}
