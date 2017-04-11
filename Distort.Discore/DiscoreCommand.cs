using System;
using System.Collections.Generic;
using Discore.WebSocket;
using Retort.Core;

namespace Distort.Discore
{
	public abstract class DiscoreCommand : Command, DiscoreCommandExecutable
	{

		public override void Execute(List<string> args) {
			return;
		}

		public abstract void Execute(List<string> args, MessageEventArgs e);

	}
}
