// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the BaseEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	using System;

	/// <summary>
	/// The base entry type.
	/// </summary>
	public abstract class BaseEvent : IEvent
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public abstract string Name { get; protected set; }

		/// <summary>
		/// Gets or sets the raw text.
		/// </summary>
		public string RawText { get; set; }

		/// <summary>
		/// Gets or sets the keystone.
		/// </summary>
		public abstract string Keystone { get; protected set; }

		/// <summary>
		/// Gets or sets the event time.
		/// </summary>
		public DateTime EventTime { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public abstract void Parse();
	}
}
