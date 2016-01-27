using System;

namespace Intro
{
	public class MuteQuack : IQuack
	{
		public void Quack()
		{
			Console.WriteLine("Can't quack!");
		}
	}
}
