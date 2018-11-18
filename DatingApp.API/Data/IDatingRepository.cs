using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Helpers;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<PageList<User>> GetUsers(UserParams userparams);
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int userId);
        Task<Like> GetLike(int userID, int recepientId);
        Task<Messages> GetMessages(int id);
        Task<PageList<Messages>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<Messages>> GetMessagesThread(int userId, int recepientId);
        
    }
}