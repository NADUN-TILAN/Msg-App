using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SingleRChat
{
	public class MyHub1 : Hub
	{
		public void Send(string name, string message)
		{	
			//call the addMessagePage method to update clients.
			Clients.All.addNewMessageToPage(name, message);
		}
	}
}