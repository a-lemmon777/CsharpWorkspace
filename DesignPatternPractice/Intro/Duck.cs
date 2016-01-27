using System;

namespace Intro
{
	public abstract class Duck
	{
		public virtual void quack()
		{
			Console.WriteLine("Quacking");
		}

		public virtual void swim()
		{
			Console.WriteLine("Swimming");
		}

		public virtual void fly()
		{
			Console.WriteLine("Flying");
		}

		public abstract void display();
	}
}
