using System;
using System.Collections.Generic;
namespace MessageStore.Models
{
    public interface IMessageRepository
    {
        IEnumerable<Message> GetAll();
        Message GetByID(int id);
        void Add(Message Message);
    }
}
