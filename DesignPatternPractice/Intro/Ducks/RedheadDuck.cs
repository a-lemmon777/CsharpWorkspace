namespace StrategyPattern
{
    using System;

    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            this.QuackBehavior = new QuackRegular();
            this.FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Redhead Duck");
        }
    }
}
