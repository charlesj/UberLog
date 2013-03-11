// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the IEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	using System;

	/// <summary>
	/// The Event interface.
	/// </summary>
	public interface IEvent
	{
		/// <summary>
		/// Gets the name.
		/// </summary>
		string Name { get;  }

		/// <summary>
		/// Gets or sets the event time.
		/// </summary>
		DateTime EventTime { get; set; }

		/// <summary>
		/// Gets or sets the raw text.
		/// </summary>
		string RawText { get; set; }

		/// <summary>
		/// Gets the keystone.
		/// </summary>
		string Keystone { get;  }

		/// <summary>
		/// The parse.
		/// </summary>
		void Parse();
	}
}