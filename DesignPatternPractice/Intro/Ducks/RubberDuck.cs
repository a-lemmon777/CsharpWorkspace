namespace StrategyPattern
{
    using System;

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.QuackBehavior = new Squeak();
            this.FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Rubber Duck");
        }
    }
}
