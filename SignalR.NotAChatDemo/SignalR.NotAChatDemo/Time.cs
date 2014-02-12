using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;

namespace SignalR.NotAChatDemo
{
	public class Time : Hub
	{
        private Timer _timer;

		public void TellMeTheTime()
		{
            if (_timer != null)
            {
                return;
            }

            _timer = new Timer(GetTime, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
		}

        private void GetTime(object sender)
        {
            Clients.All.printTime(DateTimeOffset.UtcNow);
        }
	}
}