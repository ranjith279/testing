using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessageStore.Models
{
    public class MessagesContext : DbContext
    {
        public MessagesContext()
            : base("name=MessagesContext")
        {
        }
        public DbSet<Message> Messages { get; set; }
    }
}