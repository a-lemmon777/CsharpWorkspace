namespace Intro
{
    using System;

    public class FlyNoWay : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly!");
        }
    }
}
