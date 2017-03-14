using System;
using Proto;

namespace PubSub
{
    class Program
    {
		static void Main(string[] args)
		{
			var pubProps = Actor.FromProducer(() => new PubActor());
			var pubActor = Actor.Spawn(pubProps);

			var subProps = Actor.FromProducer(() => new SubActor());
			PID subActor = Actor.Spawn(subProps);

			pubActor.Tell(subActor);
			pubActor.Tell(subActor);
			pubActor.Tell(new SubMessage
			{
				Message = "Hello to all subs 1!"
			});

			pubActor.Tell(new SubMessage
			{
				Message = "Hello to all subs 2!"
			});

			Console.ReadLine();
        }
    }
}
