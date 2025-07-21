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
    public class MessageManager : IMessageService
    {
        private readonly IMessageRepository _messageRepository;

        public MessageManager(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public async Task<Message> GetByIdAsync(int id) =>
            await _messageRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Message>> GetAllAsync() =>
            await _messageRepository.GetAllAsync();

        public async Task AddAsync(Message message)
        {
            await _messageRepository.AddAsync(message);
            await _messageRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Message message)
        {
            _messageRepository.Update(message);
            await _messageRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var message = await _messageRepository.GetByIdAsync(id);
            if (message != null)
            {
                _messageRepository.Delete(message);
                await _messageRepository.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Message>> GetMessagesByEmailAsync(string email) =>
            await _messageRepository.GetMessagesByEmailAsync(email);
    }
}
