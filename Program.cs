using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All you can eat!");
            Buffet GoldenCorral = new Buffet();
            Ninja Dan = new SweetTooth("Dan");
            Ninja Drew = new SpiceHound("Drew");
            while(Dan.IsFull == false)
            {
                Dan.Consume(GoldenCorral.Serve());
            }
            while(Drew.IsFull == false)
            {
                Drew.Consume(GoldenCorral.Serve());
            }
            if(Dan.ConsumptionHistory.Count > Drew.ConsumptionHistory.Count)
            {
                Console.WriteLine($"{ Dan.Name } consumed the most food and drink, { Dan.Name } wins!");
                Console.WriteLine($"{ Dan.Name } consumed { Dan.ConsumptionHistory.Count }. { Drew.Name } consumed { Drew.ConsumptionHistory.Count }.");
            }
            else if(Dan.ConsumptionHistory.Count == Drew.ConsumptionHistory.Count)
            {
                Console.WriteLine("Both Ninjas consumed the same amount. They are both little porkies!");
                Console.WriteLine($"{ Dan.Name } consumed { Dan.ConsumptionHistory.Count }. { Drew.Name } consumed { Drew.ConsumptionHistory.Count }.");
            }
            else
            {
                Console.WriteLine($"{ Drew.Name } ate the most food, { Drew.Name } wins!");
                Console.WriteLine($"{ Dan.Name } consumed { Dan.ConsumptionHistory.Count }. { Drew.Name } consumed { Drew.ConsumptionHistory.Count }.");
            }
        }
    }
}