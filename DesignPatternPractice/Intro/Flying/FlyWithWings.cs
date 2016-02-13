namespace StrategyPattern
{
    using System;

    public class FlyWithWings : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Flying with wings!");
        }
    }
}
