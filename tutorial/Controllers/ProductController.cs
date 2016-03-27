using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace tutorial.Controllers
{
    public class ProductController : ApiController
    {
        private NorthwindEntities db = new NorthwindEntities();

        // GET api/<controller>
        public IQueryable<Product> Get()
        {
            return db.Products;
        }

        // GET api/<controller>/5
        public Product Get(int id)
        {
            return db.Products.Find(id);
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