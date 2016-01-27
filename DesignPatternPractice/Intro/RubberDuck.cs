using System;

namespace Intro
{
	public class RubberDuck : Duck
	{
		public override	void quack()
		{
			Console.WriteLine("Squeaking");
		}

		public override void display()
		{
			Console.WriteLine("Looks like a Rubber Duck");
		}
	}
}
