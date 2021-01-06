using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyProductShop.Models
{
    public class Product
    {
        public int  ProductID { get; set; }

        [Required(ErrorMessage = "Please enter product name")]
        public  string Name { get; set; }

        [Required(ErrorMessage ="Please enter a product price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string Slug => Name == null ? "" : Name.Replace(' ', '-');

        public Category Category { get; set; }

        [Required(ErrorMessage = "please select category")]
        public int CategoryID { get; set; }// foreign key


        public decimal DiscountPercent { get; set; } = .20M;
       // public decimal DiscountPercent => .20M;
        public decimal DiscountAmount => DiscountPercent * Price;
        public decimal DiscountPrice => Price - DiscountAmount;

        [Required(ErrorMessage ="please enter product code")]
        public string Code { get; set; }

    }
}
