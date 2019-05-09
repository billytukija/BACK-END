using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiNetCore1.Models;
using Microsoft.AspNetCore.Mvc;

namespace mvcNetcore1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private DataContext db = new DataContext();

        [HttpGet()]
        public List<Product> List()
        {
            return db.Product.ToList(); 
        }

        [HttpPost("{product}")]
        public void Add([FromBody] Product product)
        {
            db.Add(product);
            db.SaveChanges();
        }
        
        [HttpGet("delete/{id}")]
        public bool Delete(int Id)
        {
            try
            {
                db.Remove(db.Product.Find(Id));
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}