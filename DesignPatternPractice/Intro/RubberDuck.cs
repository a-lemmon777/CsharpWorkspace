using System;

namespace Intro
{
	public class RubberDuck : Duck
	{
		public override	void Quack()
		{
			Console.WriteLine("Squeaking");
		}

		public override void Display()
		{
			Console.WriteLine("Looks like a Rubber Duck");
		}
	}
}
