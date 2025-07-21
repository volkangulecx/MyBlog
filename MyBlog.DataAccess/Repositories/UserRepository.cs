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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context) { }

        public async Task<User> GetUserWithProjectsAsync(int userId)
        {
            return await _dbSet // _dbSet, GenericRepository'den gelen DbSet<User>
                .Include(u => u.Projects) // Kullanıcının projelerini de dahil et
                .FirstOrDefaultAsync(u => u.Id == userId); // Kullanıcıyı ID ile bul
        }
        
    }
}
