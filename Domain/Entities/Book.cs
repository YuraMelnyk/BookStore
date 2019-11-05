using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Domain.Entities
{
    public class Book
    {
        [HiddenInput(DisplayValue = false)]
        public int BookId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a book name")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please enter a book description")]
        public string  Description { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Please enter a book category")]
        public string Category { get; set; }

        [Display(Name = "Price ($)")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a book price")]
        public decimal Price { get; set; }
    }
}
