using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant___Assignment_4.Models
{
    // Class for the user inputted restaurants
    public class AddRest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestName { get; set; }
        [Required]
        public string Dish { get; set; }
        // Phone number formatting
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; } 
    }
}
