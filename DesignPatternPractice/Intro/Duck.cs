using System;

namespace Intro
{
	public abstract class Duck
	{
		public virtual void Quack()
		{
			Console.WriteLine("Quacking");
		}

		public virtual void Swim()
		{
			Console.WriteLine("Swimming");
		}

		public virtual void Fly()
		{
			Console.WriteLine("Flying");
		}

		public abstract void Display();
	}
}
