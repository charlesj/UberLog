// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventTypes.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the EventTypes type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;

	using UberLog.Events;

	/// <summary>
	/// The event types.
	/// </summary>
	public class EventTypes
	{
		/// <summary>
		/// The get all.
		/// </summary>
		/// <returns>
		/// A list of all event types.
		/// </returns>
		public static List<Type> GetAll()
		{
			return Assembly.GetAssembly(typeof(IEvent)).GetTypes().Where(t => typeof(IEvent).IsAssignableFrom(t) && !t.IsAbstract).ToList();
		}

		/// <summary>
		/// The get instances of all.
		/// </summary>
		/// <returns>
		/// A list of instances of all events
		/// </returns>
		public static List<IEvent> GetInstancesOfAllEvents()
		{
			var types = GetAll();
			return types.Select(type => (IEvent)Activator.CreateInstance(type)).ToList();
		}
	}
}
