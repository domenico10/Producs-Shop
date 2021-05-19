using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PavolsProductShop.Models;

namespace PavolsProductShop.Controllers
{
    public class ProductController : Controller
    {
        private ShopContext context; // GET ACCESS TO THE CONTEXT USING A PRIVATE VARIABLE

        public ProductController(ShopContext ctx) // CONSTRUCTOR PASSING THE CONTEXT AS ARGUMENT
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "Product"); //REDIRECT THE USER TO THE LIST ACTION IN THE PRODUCT CONTROLLER
        }


        public IActionResult Detail(int id)
        {
            //DECLARE A VARIABLE WHICH CONTAINS ALL THE CATEGORIES OF THE CATEGORIES TABLE, ORDER BY ID AND LIST THEM ALL.
            var categories = context.Categories.OrderBy(c => c.CategoryID).ToList();

            //PRODUCT OBJECT = GO IN THE CONTEXT WHICH IS THE SHOPCONTEXT CLASS, THEN PRODUCTS TABLE AND FIND THE PRODUCT WHICH MATCHES THE ID WITH THE ID PASSED AS ARGUMENT
            Product product = context.Products.Find(id);

            var categoryName = "";

            foreach(var category in categories)
            {
                if(category.CategoryID == product.ProductID) {
                    categoryName = category.Name;
                }
            }

            string imageFilename = product.Code + "-m.jpg";//RETRIEVE THE IMAGE OF A PRODUCT

            ViewBag.ImageFilename = imageFilename;

            ViewBag.Categories = categoryName;

            return View(product);
        }
        [Route("[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {
            //DECLARE A VARIABLE WHICH CONTAINS ALL THE CATEGORIES OF THE CATEGORIES TABLE, ORDER BY ID AND LIST THEM ALL.
            var categories = context.Categories.OrderBy(c => c.CategoryID).ToList();

            List<Product> products;//LIST OF PRODUCT TO BE PASSED INTO VIEW

            if(id == "All") //IF ID IS EQUAL TO ALL.. IF THE ID IS NOT SPECIFIED
            {
                products = context.Products.OrderBy(p => p.ProductID).ToList();//SELECT ALL THE PRODUCTS AND ORDER BY PRODUCT ID
            }  
            else if(id == "Specials")
            {
                products = context.Products.Where(p => p.Price < 5.0M).OrderBy(p => p.ProductID).ToList();
            }
            else // IF THE ID IS SELECTED, DISPLAY THE PRODUCTS WHERE THE CATEGORY ID IS EQUAL AT THE ID IN THE URL AND ORDER BY PRODUCT ID
            {
                products = context.Products.Where(p => p.Category.Name == id).OrderBy(p => p.ProductID).ToList(); 
            }

            var model = new ProductListViewModel
            {
                Categories = categories,
                Products = products,
                SelectedCategory = id
            };
            
            return View(model);
        }
    }
}