﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;

[assembly:OwinStartup(typeof(SingleRChat.Startup))]
namespace SingleRChat
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			//Ant connection or hub wire up and configuration should go here
			app.MapSignalR();
		}
	}
}