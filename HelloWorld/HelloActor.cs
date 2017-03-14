using System;
using System.Threading.Tasks;
using Proto;

namespace ProtoActorHelloWorld
{
	public class HelloActor : IActor
	{
	    public Task ReceiveAsync(IContext context)
   	 	{

			var msg = context.Message;
        	if (msg is Hello r)
        	{
            	Console.WriteLine($"Hello {r.Who}");
        	}
        	return Actor.Done;
    	}
	}
}
