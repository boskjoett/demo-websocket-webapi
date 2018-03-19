using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebSocketWebApplication.Models;

namespace WebSocketWebApplication.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IRepository repository;

        public ValuesController(IRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<RepositoryItem> Get()
        {
            return repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public RepositoryItem Get(int id)
        {
            return repository.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post(RepositoryItem item)
        {
            repository.Add(item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, RepositoryItem item)
        {
            repository.Update(id, item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Remove(id);
        }
    }
}
