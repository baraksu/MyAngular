using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Yad2.Controllers
{
    public class RentController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<RentApartment> Get()
        {
            IDataRepository data = new DataRepository();

            var a= data.GetAppartments();

            return a;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}