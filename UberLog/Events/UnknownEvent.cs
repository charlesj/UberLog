﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnknownEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the UnknownEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The unknown entry type.
	/// </summary>
	public class UnknownEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UnknownEvent"/> class.
		/// </summary>
		public UnknownEvent()
		{
			this.Name = "Unknown";
			this.Keystone = this.GetType().ToString();
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
			// nothing to do.
		}
	}
}
