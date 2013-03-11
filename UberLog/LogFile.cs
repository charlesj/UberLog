// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogFile.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the LogFile type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog
{
	using System;
	using System.Collections.Generic;

	using UberLog.Events;

	/// <summary>
	/// The log file.
	/// </summary>
	public class LogFile
	{
		/// <summary>
		/// Gets or sets the log entries.
		/// </summary>
		public List<UnparsedEvent> RawEvents { get; set; }

		/// <summary>
		/// Gets the events.
		/// </summary>
		public List<IEvent> Events { get; private set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public void Parse()
		{
			this.Events = new List<IEvent>();
			var types = EventTypes.GetAll();
			foreach (var rawevent in this.RawEvents)
			{
				var found = false;
				foreach (var type in types)
				{
					var instance = (IEvent)Activator.CreateInstance(type);
					if (rawevent.RawText.Contains(instance.Keystone))
					{
						instance.RawText = rawevent.RawText;
						this.Events.Add(instance);
						found = true;
					}
				}

				if (!found)
				{
					this.Events.Add(new UnknownEvent() { RawText = rawevent.RawText });
				}
			}
		}
	}
}
