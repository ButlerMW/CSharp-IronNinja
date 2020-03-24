using System;

namespace IronNinja
{
    class SweetTooth : Ninja
    {
        public SweetTooth(string name) : base(name)
        {
            IsFull = false;
        }
        
        public override bool IsFull {get; set;}
        public override void Consume(IConsumable item)
        {
            if(IsFull == false)
            {
                Console.WriteLine($"{ Name } consumes { item.Name }");
                if(item.IsSweet == true)
                {
                    Console.WriteLine($"{item.Name} is sweet! { Name } is Happy!");
                    CalorieIntake += 10;
                }
                CalorieIntake += item.Calories;
                Console.WriteLine(CalorieIntake);
                ConsumptionHistory.Add(item);
                item.GetInfo();
                if(CalorieIntake >= 1500)
                {
                    Console.WriteLine($"{ Name } is FULL and can't consume anymore!!!");
                    IsFull = true;
                }   
            }
            else
            {
                Console.WriteLine($"{ Name } is FULL and can't consume anymore!!!");
            }
        }
    }
}