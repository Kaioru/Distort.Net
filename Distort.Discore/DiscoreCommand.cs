using System;
using System.Collections.Generic;
using Discore.WebSocket;
using Retort.Core;

namespace Distort.Discore
{
	public abstract class DiscoreCommand : Command, DiscoreCommandExecutable
	{
		
		public void Execute(List<string> args, MessageEventArgs e)
		{
			return;
		}

	}
}
