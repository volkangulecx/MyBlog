using MyBlog.Entities.Models;

namespace MyBlog.PresentationLayer.Models
{
    public class AdminPanelViewModel
    {
        public List<MyBlog.Entities.Models.Project> Projects { get; set; }
        public List<MyBlog.Entities.Models.Message> Messages { get; set; }
    }
}
