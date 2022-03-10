using System;

namespace CommandPattern
{
	/// <summary>
	/// The concrete command class.
	/// </summary>
	public class ConcreteCommand : Command
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CommandPattern.ConcreteCommand"/> class.
		/// </summary>
		/// <param name="receiver">The receiver to use.</param>
		public ConcreteCommand(Receiver receiver) :
			base(receiver)
		{
			Console.WriteLine ("New command created");
		}

		/// <summary>
		/// Execute the command.
		/// </summary>
		public override void Execute()
		{
			Console.WriteLine ("Command.Execute() called");
			receiver.Action();
		}
	}
	
}
