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
        // PROF�L k�sm�n� istersen yine statik tutabilirsin:
        var model = new ProfileViewModel
        {
            FullName = "Volkan G�le�",
            About = "Merhaba! Ben Volkan...",
            Education = "Ar� Bilgi ve Bili�im Teknolojileri Akademisi",
            ProfileImage = "/images/a.png",
            Location = "�stanbul,Kad�k�y - T�rkiye",
            Linkedin = "https://linkedin.com/in/volkangulec",
            Github = "https://github.com/volkangulecx",

            // --- Projelerin Home ekran�nda g�r�nmesi i�in ---
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
            TempData["MessageResult"] = "Mesaj�n�z ba�ar�yla iletildi!";
            return RedirectToAction("Index");
        }
        TempData["MessageResult"] = "Mesaj g�nderilirken hata olu�tu!";
        return RedirectToAction("Index");
    }
}


