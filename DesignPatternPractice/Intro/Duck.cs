using System;

namespace Intro
{
	public abstract class Duck
	{
		public void quack()
		{
			Console.WriteLine("Quacking");
		}

		public void swim()
		{
			Console.WriteLine("Swimming");
		}

		public abstract void display();
	}
}
