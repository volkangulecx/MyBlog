using MyBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.Business.Abstract.IServices
{
    public interface IProjectService
    {
        Task<Project> GetByIdAsync(int id);
        Task<IEnumerable<Project>> GetAllAsync();
        Task AddAsync(Project project);
        Task UpdateAsync(Project project);
        Task DeleteAsync(int id);

        // Belirli kullanıcıya ait projeleri getirmek için
        Task<IEnumerable<Project>> GetProjectsByUserIdAsync(int userId);
    }
}
