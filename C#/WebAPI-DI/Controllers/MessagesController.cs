using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MessageStore.Models;

namespace MessageStore.Controllers
{
    public class MessagesController : ApiController
    {
        IMessageRepository _repository;

        public MessagesController(IMessageRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Message> Get()
        {
            
            return _repository.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var Message = _repository.GetByID(id);
            if (Message == null)
            {
                return NotFound();
            }
            return Ok(Message);
        }

        public IHttpActionResult Post(Message Message)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repository.Add(Message);
            return CreatedAtRoute("DefaultApi", new { id = Message.Id }, Message);
        }
    }
}
