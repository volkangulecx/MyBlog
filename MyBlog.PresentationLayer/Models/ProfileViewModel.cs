namespace MyBlog.PresentationLayer.Models
{
    public class ProfileViewModel
    {
        public required string FullName { get; set; }
        public required string About { get; set; }
        public required string Education { get; set; }
        public required string ProfileImage { get; set; }
        public List<ProjectViewModel> Projects { get; set; } = new List<ProjectViewModel>();
        public List<MessageViewModel> Messages { get; set; } = new List<MessageViewModel>();

        // Ek sosyal medya, lokasyon gibi alanlar eklemek için
        public required string Location { get; set; }
        public required string Linkedin { get; set; }
        public required string Github { get; set; }
    }
}
