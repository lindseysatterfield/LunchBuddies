using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"Your best lunchbuddy, {FirstName} {LastName}, is eating at {restaurant.RestaurantName}.");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Your best lunchbuddy, {FirstName} {LastName}, is eating {food} at the office.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName}, your bestie lunch buddy, is at {restaurant.RestaurantName} with the following buddies:  ");
            foreach (var companion in companions)
            {
                Console.WriteLine($"{companion.FirstName} {companion.LastName}");
            }
        }

        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.RestaurantName} and ordered {food} with the following buddies: ");
            foreach (var companion in companions)
            {
                Console.WriteLine($"{companion.FirstName} {companion.LastName}");
            }
        }
    }
}
