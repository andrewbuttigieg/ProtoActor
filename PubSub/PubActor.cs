using System;
using Proto;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace PubSub
{
	public class PubActor: IActor
	{
		List<PID> subs = new List<PID>();
		public Task ReceiveAsync(IContext context)
   	 	{
			var msg = context.Message;
			if (msg is PID)
			{
				subs.Add(context.Message as PID);
				Console.WriteLine("Added a sub");
			}
			if (msg is SubMessage)
			{
				subs.ForEach(c => c.Tell(msg as SubMessage));
			}
			return Actor.Done;
    	}
	}
}
