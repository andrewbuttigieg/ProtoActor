using System;
using Proto;

namespace ProtoActorHelloWorld
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
			Console.ReadLine();
        }
    }
}
