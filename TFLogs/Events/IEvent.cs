// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the IEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	using System;

	public interface IEvent
	{
		string Name { get;  }

		DateTime EventTime { get; set; }

		string RawText { get; set; }

		string Keystone { get;  }
	}
}