namespace Intro
{
    using System;

    public class Squeak : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}