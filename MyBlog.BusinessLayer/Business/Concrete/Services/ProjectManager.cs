using MyBlog.BusinessLayer.Business.Abstract.IServices;
using MyBlog.DataAccess.IRepositories;
using MyBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.Business.Concrete.Services
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectManager(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Project> GetByIdAsync(int id) =>
            await _projectRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Project>> GetAllAsync() =>
            await _projectRepository.GetAllAsync();

        public async Task AddAsync(Project project)
        {
            await _projectRepository.AddAsync(project);
            await _projectRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Project project)
        {
            _projectRepository.Update(project);
            await _projectRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var project = await _projectRepository.GetByIdAsync(id);
            if (project != null)
            {
                _projectRepository.Delete(project);
                await _projectRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Project>> GetProjectsByUserIdAsync(int userId) =>
            await _projectRepository.GetProjectsByUserIdAsync(userId);
    }
}
