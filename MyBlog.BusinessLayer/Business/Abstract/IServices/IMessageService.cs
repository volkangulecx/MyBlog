using MyBlog.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.Business.Abstract.IServices
{
    public interface IMessageService
    {
        Task<Message> GetByIdAsync(int id);
        Task<IEnumerable<Message>> GetAllAsync();
        Task AddAsync(Message message);
        Task UpdateAsync(Message message);
        Task DeleteAsync(int id);

        // Özel metot: E-posta adresine göre mesajları getir
        Task<IEnumerable<Message>> GetMessagesByEmailAsync(string email);
    }
}
