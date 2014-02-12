using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.NotAChatDemo
{
	public class Time : Hub
	{
		public void TellMeTheTime()
		{
			Clients.All.printTime(DateTime.Now.ToString());
		}
	}
}