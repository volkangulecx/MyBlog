using MyBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        // User'a özel metotlar buraya
        Task<User> GetUserWithProjectsAsync(int userId);
        // Örneğin: Kullanıcıya ait tüm projeleri ve detaylarını döndürmek
    }
}
