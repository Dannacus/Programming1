using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectProducts2.Models;

namespace ProjectProducts2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> aListOfProducts = new List<Product>();

            string[] names = System.IO.File.ReadAllLines(@"C:\Users\Dannacus\OneDrive - Alfred State College\Documents\Fall2017\Programming 1\Products.txt");
            int[] id = new int[names.Length];
            for (int index = 0; index < names.Length; index++)
            {
                string[] tokens = names[index].Split(',');
                Product aProduct1 = new Product();
                aProduct1.ProductId = Convert.ToInt32(tokens[0]);
                aProduct1.ProductName = tokens[1];
                aProduct1.UnitPrice = tokens[2];
                aProduct1.SupplierId = Convert.ToInt32(tokens[3]);
                aProduct1.CompanyId = Convert.ToInt32(tokens[4]);

                
                aListOfProducts.Add(aProduct1);
            }

            ViewBag.ProductList = aListOfProducts;

            
            return View();
            
        }
    }
}