using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebSocketWebApplication.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        int[] values = { 0, 10, 20, 30, 40, 50 };

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            foreach (int i in values)
            {
                yield return i.ToString();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Value at index {id} = {values[id]}";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            values[id] = int.Parse(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            values[id] = -1;
        }
    }
}
