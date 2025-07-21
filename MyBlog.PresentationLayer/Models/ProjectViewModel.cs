namespace MyBlog.PresentationLayer.Models
{
    public class ProjectViewModel
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public string? Link { get; set; }
        // Proje görseli için :
        public string? ImageUrl { get; set; }
    }
}
