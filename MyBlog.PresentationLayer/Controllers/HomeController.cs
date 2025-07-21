using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Data;
using MyBlog.Entities.Models;
using MyBlog.PresentationLayer.Models;
using System.Diagnostics;

namespace MyBlog.PresentationLayer.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _dbContext;

    public HomeController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        // PROFÝL kýsmýný istersen yine statik tutabilirsin:
        var model = new ProfileViewModel
        {
            FullName = "Volkan Güleç",
            About = "Merhaba! Ben Volkan...",
            Education = "Arý Bilgi ve Biliþim Teknolojileri Akademisi",
            ProfileImage = "/images/a.png",
            Location = "Ýstanbul,Kadýköy - Türkiye",
            Linkedin = "https://linkedin.com/in/volkangulec",
            Github = "https://github.com/volkangulecx",

            // --- Projelerin Home ekranýnda görünmesi için ---
            Projects = _dbContext.Projects
            .Select(p => new ProjectViewModel
            {
                Title = p.Title,
                Description = p.Description,
                Link = p.Link

            }).ToList(),

            Messages = _dbContext.Messages
            .OrderByDescending(m => m.SentAt)
            .Select(m => new MessageViewModel
            {
                Name = m.Name,
                Email = m.Email,
                Content = m.Content,
                SentAt = m.SentAt
            }).ToList()
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult SendMessage(MessageViewModel message)
    {
        if (ModelState.IsValid)
        {
            var msg = new Message
            {
                Name = message.Name,
                Email = message.Email,
                Content = message.Content,
                SentAt = DateTime.Now
            };
            _dbContext.Messages.Add(msg);
            _dbContext.SaveChanges();
            TempData["MessageResult"] = "Mesajýnýz baþarýyla iletildi!";
            return RedirectToAction("Index");
        }
        TempData["MessageResult"] = "Mesaj gönderilirken hata oluþtu!";
        return RedirectToAction("Index");
    }
}


