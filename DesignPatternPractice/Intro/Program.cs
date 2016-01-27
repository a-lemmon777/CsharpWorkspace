using System;

namespace Intro
{
	class Program
	{
		static void Main(string[] args)
		{
			Duck myDuck = new MallardDuck();
			myDuck.quack();
			myDuck.swim();
			myDuck.display();
			myDuck = new RedheadDuck();
			myDuck.quack();
			myDuck.swim();
			myDuck.display();
			Console.ReadKey();
		}
	}
}
