using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Url]
        public string? Link { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // FK ve Navigation (isteğe bağlı, ileride ekleyebilirsin)
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
