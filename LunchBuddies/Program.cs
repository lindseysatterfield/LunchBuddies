using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lindsey = new LunchBuddy("Lindsey", "Satterfield");
            lindsey.Eat();
            lindsey.Eat("pizza");
            Console.WriteLine();

            var john = new LunchBuddy("John", "Doe");
            john.Eat();
            john.Eat("chips");
            Console.WriteLine();

            var jane = new LunchBuddy("Jane", "Doe");
            jane.Eat(new List<LunchBuddy>() {
                new LunchBuddy("Winnie the", "Pooh"),
                new LunchBuddy("Barack", "Obama"),
                new LunchBuddy("Oprah", "Winfrey")
            });
            Console.WriteLine();

            var luke = new LunchBuddy("Luke", "Skywalker");
            luke.Eat("pasta", new List<LunchBuddy>() {
                new LunchBuddy("Homer", "Simpson"),
                new LunchBuddy("Hank", "Hill"),
                new LunchBuddy("Peter", "Griffin")
            });
        }
    }
}
