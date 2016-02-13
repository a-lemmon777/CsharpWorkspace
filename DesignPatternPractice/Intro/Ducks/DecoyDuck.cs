namespace StrategyPattern
{
    using System;

    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.QuackBehavior = new MuteQuack();
            this.FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Decoy");
        }
    }
}