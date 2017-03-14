using System;
using Proto;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
			var props = Actor.FromProducer(() => new HelloActor());
			var pid = Actor.Spawn(props);
			pid.Tell(new Hello
			{
				Who = "Alex"
			});

			pid.Tell(new Hello
			{
				Who = "Bill"
			});

			Console.ReadLine();
        }
    }
}
