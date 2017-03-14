using System;
using Proto;
using System.Threading.Tasks;

namespace PubSub
{
	public class SubActor: IActor
	{
		public Task ReceiveAsync(IContext context)
   	 	{
			var msg = context.Message;
			if (msg is SubMessage)
			{
				Console.WriteLine((msg as SubMessage).Message);
			}
			return Actor.Done;
    	}
	}
}
