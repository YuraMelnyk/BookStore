using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Your full name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your address")]
        [Display(Name = "The first address")]
        public string Line1 { get; set; }

        [Display(Name = "Second address")]
        public string Line2 { get; set; }

        [Display(Name = "Third address")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Your city")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Your country")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
