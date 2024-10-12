using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {

        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Price must be obligatory")]
        public float Price { get; set; }


        [DisplayName("Stock")]
        [Required(ErrorMessage = "Stock is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Stock must be obligatory")]
        public float Stock { get; set; }


        [DisplayName("Category")]
        [Required(ErrorMessage = "Category is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Category must be obligatory")]
        public string Category { get; set; }





    }
}
