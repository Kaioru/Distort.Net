using System;
using System.Collections.Generic;
using Discore.WebSocket;
using Retort.Core;

namespace Distort.Discore
{
	public interface DiscoreCommandExecutable : ICommandExecutable
	{

		void Execute(List<String> args, MessageEventArgs e);

	}
}
