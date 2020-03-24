using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
        {
            public List<IConsumable> Menu;

            public Buffet()
            {
                Menu = new List<IConsumable>()
                {   
                    new Food("Curry", 500, true, false),
                    new Food("Sushi", 250, false, false),
                    new Food("Gyro", 700, true, false),
                    new Food("Mystery Meat", 100, false, false),
                    new Food("Steak n Taters", 800, false, false),
                    new Food("Ice Cream", 500, false, true),
                    new Food("BBQ", 1000, true, true),
                    new Drink("Soda", 150, false, true),
                    new Drink("Tea", 50, false, true),
                    new Drink("Milkshake", 500, false, true),
                    new Drink("Smoothie", 350, false, true)
                };
            }

            public IConsumable Serve()
            {
                Random rand = new Random();       
                int x = rand.Next(0,11);
                Console.WriteLine($"Buffet is serving {Menu[x].Name}");
                return Menu[x]; 
            }

        }
}