using PWEWebIpiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PWEWebIpiTest.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Room> Get()
        {
            List<Room> result = new List<Room>();
            // creating a rooms and add them to the list
            Room r1 = new Room();
            r1.Id = 1;
            r1.Name = "First room";
            r1.RoomNo = "101";
            r1.Occupied = false;
            result.Add(r1);

            Room r2 = new Room() { Id = 2, Name = "Second room", Occupied = true, RoomNo = "102" };
            result.Add(r2);
            return result;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]Room value)
        {
            Console.WriteLine(value.ToString());
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
