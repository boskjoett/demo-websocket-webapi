using System.Collections.Generic;

namespace WebSocketWebApplication.Models
{
    public interface IRepository
    {
        void Add(RepositoryItem item);
        RepositoryItem Get(int id);
        IEnumerable<RepositoryItem> GetAll();
        void Remove(int id);
        void Update(int id, RepositoryItem item);
    }
}