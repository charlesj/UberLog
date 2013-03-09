// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogStartedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The log started event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The log started event.
	/// </summary>
	public class LogStartedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LogStartedEvent"/> class.
		/// </summary>
		public LogStartedEvent()
		{
			this.Keystone = "Log file started";
			this.Name = "LogStarted";
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public override string Name { get; protected set; }

		/// <summary>
		/// Gets or sets the keystone.
		/// </summary>
		public override string Keystone { get; protected set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			throw new System.NotImplementedException();
		}
	}
}