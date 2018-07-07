using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageStore.Models
{
    public class MessageRepository : IDisposable, MessageStore.Models.IMessageRepository
    {
        private MessagesContext db = new MessagesContext();
        Message[] Messages = new Message[]
       {
            new Message { Id = 1, Name = "Hello World"}
       };
        public IEnumerable<Message> GetAll()
        {
            return Messages;
        }
        public Message GetByID(int id)
        {
            return db.Messages.FirstOrDefault(p => p.Id == id);
        }
        public void Add(Message Message)
        {
            db.Messages.Add(Message);
            db.SaveChanges();
        }

        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}