namespace StrategyPattern
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Duck[] myDucks = { new MallardDuck(), new RedheadDuck(), new RubberDuck(), new DecoyDuck() };
            foreach (Duck duck in myDucks)
            {
                DoDuckThings(duck);
            }

            myDucks[0].QuackBehavior = new Squeak();
            DoDuckThings(myDucks[0]);
            Console.ReadKey();
        }

        private static void DoDuckThings(Duck duck)
        {
            duck.Display();
            duck.PerformQuack();
            duck.Swim();
            duck.PerformFly();
        }
    }
}
