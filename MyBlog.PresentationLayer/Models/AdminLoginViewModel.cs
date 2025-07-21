using System.ComponentModel.DataAnnotations;

namespace MyBlog.PresentationLayer.Models
{
    public class AdminLoginViewModel
    {
        [Required]
        public required string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
