using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Proto;

namespace HelloWorld
{
	public class HelloActor : IActor
	{
		private List<Hello> messages = new List<Hello>();

	    public Task ReceiveAsync(IContext context)
   	 	{
			var msg = context.Message;
        	if (msg is Hello r)
        	{
				messages.Add(msg as Hello);
				Console.WriteLine($"Hello {r.Who}, I have received {messages.Count} messages.");
        	}

			return Actor.Done;
    	}
	}
}
