using System;

namespace Intro
{
	public class Program
	{
		static void Main(string[] args)
		{
			Duck[] myDucks = { new MallardDuck(), new RedheadDuck(), new RubberDuck() };
			foreach (Duck duck in myDucks)
			{
				duck.Display();
				duck.Quack();
				duck.Swim();
				duck.Fly();
			}
			Console.ReadKey();
		}
	}
}
