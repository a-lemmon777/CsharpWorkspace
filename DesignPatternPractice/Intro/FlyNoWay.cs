using System;

namespace Intro
{
	public class FlyNoWay : IFly
	{
		public void Fly()
		{
			Console.WriteLine("Can't fly!");
		}
	}
}
