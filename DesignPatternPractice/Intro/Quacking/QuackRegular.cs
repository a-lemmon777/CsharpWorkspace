namespace StrategyPattern
{
    using System;

    public class QuackRegular : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I'm Quacking!");
        }
    }
}
