using System;

namespace CommandPattern
{
	/// <summary>
	/// The client class.
	/// </summary>
	public class Client
	{
		/// <summary>
		/// Run the client.
		/// </summary>
		public void Run ()
		{
			Console.WriteLine ("Client.Run() called");

			// set up receiver
			Receiver receiver = new Receiver();

			// create command and link it to receiver
			Command command = new ConcreteCommand(receiver);

			// pass the command to the invoker and invoke it
			Invoker invoker = new Invoker();
			invoker.Invoke(command);
		}
	}
}

