using System.Collections.Generic;

namespace IronNinja
{
    abstract class Ninja
    {
        public string Name;
        protected int CalorieIntake;
        public List<IConsumable> ConsumptionHistory;
        public Ninja(string name)
        {
            Name = name;
            CalorieIntake = 0;
            ConsumptionHistory = new List<IConsumable>();
        }
        public abstract bool IsFull {get; set;} // Is there a way to use this with just {get;} ??????

        public abstract void Consume(IConsumable item);
    }
}