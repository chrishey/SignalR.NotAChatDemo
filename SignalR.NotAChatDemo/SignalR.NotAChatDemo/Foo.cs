using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;

namespace SignalR.NotAChatDemo
{
	public class Foo : Hub
	{
        private const string ERROR_MESSAGE = "Sorry - your name is not recognised!";
        private const string DEFAULT_MESSAGE = "Hello {0} {1}!";

		public void EnterName(dynamic data)
		{
            string message = ERROR_MESSAGE;

            if (data != null)
            {
                message = string.Format(DEFAULT_MESSAGE, data.firstName, data.lastName);
            }

            PrintName(message);
		}

        private void PrintName(string message)
        {
            Clients.All.printName(message);
        }
	}
}