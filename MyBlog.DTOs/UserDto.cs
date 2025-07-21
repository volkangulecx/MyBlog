using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public string? About { get; set; }
        public required string Education { get; set; }
        public required string ProfileImage { get; set; }
        // Gerekirse sadece okunacak tipte projeler eklemek için.
        public List<ProjectDto> Projects { get; set; } = new List<ProjectDto>();
    }
}
