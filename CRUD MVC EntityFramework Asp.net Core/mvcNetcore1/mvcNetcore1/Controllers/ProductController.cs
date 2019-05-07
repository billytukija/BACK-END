using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcNetcore1.Models;

namespace mvcNetcore1.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private DataContext db = new DataContext();

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.Products = db.Product.ToList(); 
            return View();
        }

        [HttpGet]
        [Route("Add")]
        public IActionResult Add()
        {
            return View("Add", new Product());
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Product product)
        {
                db.Add(product);
                db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit")]
        public IActionResult Edit(int Id)
        {
            return View("Edit", db.Product.Find(Id));
        }

        [HttpPost]
        [Route("edit")]
        public IActionResult Edit(Product product)
        {

            //db.Add(product);
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int Id)
        {
            db.Remove(db.Product.Find(Id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}