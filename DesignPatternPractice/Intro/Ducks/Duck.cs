namespace StrategyPattern
{
    using System;

    public abstract class Duck
    {
        public IFly FlyBehavior { get; set; }

        public IQuack QuackBehavior { get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            this.FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            this.QuackBehavior.Quack();
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
