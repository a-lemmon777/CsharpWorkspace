namespace Intro
{
    using System;

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.QuackBehavior = new QuackRegular();
            this.FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Looks like a Mallard");
        }
    }
}
