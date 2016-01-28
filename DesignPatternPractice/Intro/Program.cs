namespace Intro
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Duck[] myDucks = { new MallardDuck(), new RedheadDuck(), new RubberDuck(), new DecoyDuck() };
            foreach (Duck duck in myDucks)
            {
                duck.Display();
                duck.PerformQuack();
                duck.Swim();
                duck.PerformFly();
            }

            Console.ReadKey();
        }
    }
}
