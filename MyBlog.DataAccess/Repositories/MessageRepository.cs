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
    public class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Message>> GetMessagesByEmailAsync(string email)
        {
            return await _dbSet
                .Where(m => m.Email == email)
                .ToListAsync();
        }
    }
}
