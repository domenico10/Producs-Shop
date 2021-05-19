using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PavolsProductShop.Models
{
    public class Product
    {

        public int ProductID { get; set; }

        [Required(ErrorMessage ="Please enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter product price")]
        [Column(TypeName ="decimal(18,2)")] //IS USED TO REPRESENT THE DATA IN THE DATABASE COLUMN -- DECIMAL, TWO DECIMAL POINTS AND NO MORE THAN 18 CHARACTERS
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Please select a category")]
        public int CategoryID { get; set; }//foreign key

        public Category Category { get; set; }

        public decimal DiscountPercent => .20M; //DISCOUNT PERCENTAGE
        public decimal DiscountAmount => Price * DiscountPercent;// DISCOUNT AMOUNT
        public decimal DiscountPrice => Price - DiscountAmount;//PRICE DISCOUNTED

        [Required(ErrorMessage ="Please enter product code")]
        public string Code { get; set; }

        public string Slug => Name == null ? "" : Name.Replace(' ', '-');// Changes the white spaces in the url with the dash symbol ( - )
                     //IF NAME IS == NULL RETURN EMPTY; IF NOT NULL REPLACE THE SPACES WITH THE DASH
    }
}
