// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogEndedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The log ended event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The log ended event.
	/// </summary>
	public class LogEndedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LogEndedEvent"/> class.
		/// </summary>
		public LogEndedEvent()
		{
			this.Keystone = "Log file closed";
			this.Name = "LogEnded";
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