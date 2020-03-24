using System;

namespace IronNinja
{
    class SpiceHound : Ninja
    {
        public SpiceHound(string name) : base(name)
        {
            IsFull = false;
        }
        
        public override bool IsFull {get; set;}
        public override void Consume(IConsumable item)
        {
            if(IsFull == false)
            {
                Console.WriteLine($"{ Name } consumes { item.Name }");
                if(item.IsSpicy == true)
                {
                    Console.WriteLine($"{ item.Name } is spicy! { Name } is Happy!");
                    CalorieIntake -= 5;
                }
                CalorieIntake += item.Calories;
                Console.WriteLine(CalorieIntake);
                ConsumptionHistory.Add(item);
                item.GetInfo();
                if(CalorieIntake >= 1200)
                {
                    Console.WriteLine($"{ Name } is FULL and can't consume anymore!!!");
                    IsFull = true;
                }
            }
            else
            {
                Console.WriteLine($"{ Name } is FULL and can't consume amymore!");
            }
        }
    }
}