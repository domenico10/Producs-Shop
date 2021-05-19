using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PavolsProductShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Please enter category name")]
        public string Name { get; set; }

    }
}
