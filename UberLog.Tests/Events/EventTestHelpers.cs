// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventTestHelpers.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the EventTestHelpers type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Tests.Events
{
	using UberLog.Events;

	/// <summary>
	/// The base event tests.
	/// </summary>
	public class EventTestHelpers
	{
		/// <summary>
		/// The build and parse.
		/// </summary>
		/// <param name="logText">
		/// The log text.
		/// </param>
		/// <typeparam name="T">
		/// The type to build and parse
		/// </typeparam>
		/// <returns>
		/// The <see cref="T"/>.
		/// </returns>
		public static T BuildAndParse<T>(string logText) where T : IEvent, new()
		{
			var evt = new T { RawText = logText };
			evt.Parse();
			return evt;
		}
	}
}
