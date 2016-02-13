namespace StrategyPattern
{
    using System;

    public class MuteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Can't quack!");
        }
    }
}
