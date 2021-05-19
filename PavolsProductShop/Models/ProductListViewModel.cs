using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PavolsProductShop.Models
{
    public class ProductListViewModel
    {
        public List<Category> Categories { get; set; } //LIST OF CATEGORIES
        public List<Product> Products { get; set; }// LIST OF PRODUCTS
        public string SelectedCategory { get; set; }// CSS TO HIGHLIGHT THE SELECTED CATEGORY
        public string CheckActiveCategory(string category) => category == SelectedCategory ? "active" : ""; //CSS TO MAKE THE SELECTED CATEGORY ACTIVE
    }
}
