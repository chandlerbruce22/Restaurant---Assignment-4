using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant___Assignment_4.Models
{
    public class Restaurants
    {
        [Required]
        public int Rank { get; set; }
        [Required]
        public string Name { get; set; }
        // Null protected. Controller will handle default value
        public string? Dish { get; set; }
        [Required]
        public string Address { get; set; }
        // Formatting of the phone number input
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        // Null Protected
        public string? Phone { get; set; }
        // Null protected, assigns a default value of coming soon
        public string? Website { get; set; } = "Coming Soon!";

        // Hardcoded data for the top 5 restaurants to appear on the index page.
        public static Restaurants[] GetRestaurants()
        {
            Restaurants b1 = new Restaurants
            {
                Rank = 1,
                Name = "Raising Canes",
                Dish = "The Caniac",
                Address = "132 W. 1230 North",
                Phone = "702-912-4890"
            };

            Restaurants b2 = new Restaurants
            {
                Rank = 2,
                Name = "The Habit",
                Dish = "Double Cheeseburger",
                Address = "2245 N.University Parkway Provo, UT 84604",
                Phone = "385-254-0940",
                Website = "habitburger.com"
            };

            Restaurants b3 = new Restaurants
            {
                Rank = 3,
                Name = "Chipotle",
                Dish = "Chicken Burrito with everything on it.",
                Address = "715 E. University Pkwy, Orem, UT 84097",
                Phone = "801-225-4364",
                Website = "chipotle.com"
            };

            Restaurants b4 = new Restaurants
            {
                Rank = 4,
                Name = "Chick-Fil-A",
                Address = "484 W. Bulldog Blvd, Provo, UT 84604",
                Phone = "801-374-2697",
                Website = "chick-fil-a.com"
            };

            Restaurants b5 = new Restaurants
            {
                Rank = 5,
                Name = "Chilis",
                Dish = "Chicken Bacon Ranch Quesadilla",
                Address = "122 E. 1300 S. Orem, UT 84058",
                Phone = "801-221-0884",
                Website = "chilis.com"
            };

            // Final return information
            return new Restaurants[] { b1, b2, b3, b4, b5 };
        }

    }
}
