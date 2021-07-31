using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restaurant
    {
        public string RestaurantName { get; set; }
        private List<string> RestaurantNames { get; set; } = new List<string>();

        public Restaurant()
        {
            RestaurantNames.Add("Bourbon Steak");
            RestaurantNames.Add("Mas Tacos");
            RestaurantNames.Add("The Optimist");
            RestaurantNames.Add("Earnest Bar & Hideaway");
            RestaurantNames.Add("Five Points Pizza");
            RestaurantNames.Add("Bella Napoli");

            var random = new Random();
            var restaurantList = RestaurantNames;
            int index = random.Next(restaurantList.Count);
            RestaurantName = restaurantList[index];
        }
    }
}
