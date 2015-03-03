using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CentralizedConfiguration.Controllers
{
    public class SitesController : ApiController
    {
        // GET api/sites
        public IEnumerable<string> Get()
        {
            return new string[] { "Site1", "Site2" };
        }

        // GET api/sites/5
        public string Get(int id)
        {
            return "site";
        }

        // POST api/sites
        public void Post([FromBody]string value)
        {
        }

        // PUT api/sites/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/sites/5
        public void Delete(int id)
        {
        }
    }
}
