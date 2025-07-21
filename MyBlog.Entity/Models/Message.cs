using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Entities.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(500)]
        public string Content { get; set; } = string.Empty;

        public DateTime SentAt { get; set; } = DateTime.Now;

        // Eğer mesajı bırakan bir kullanıcı olacaksa:
         public int? UserId { get; set; }
         public User? User { get; set; }
    }
}
