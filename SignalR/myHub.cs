using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR
{
	public class myHub : Hub
	{
		public void Announce(string message)
		{
			Clients.All.Announce(message);
		}
	}
}