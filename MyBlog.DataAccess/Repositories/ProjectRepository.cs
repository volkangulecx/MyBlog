using Microsoft.EntityFrameworkCore;
using MyBlog.DataAccess.Data;
using MyBlog.DataAccess.IRepositories;
using MyBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Project>> GetProjectsByUserIdAsync(int userId)
        {
            return await _dbSet
                .Where(p => p.UserId == userId)
                .ToListAsync();
        }
    }
}
