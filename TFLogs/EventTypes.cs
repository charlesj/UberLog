// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EventTypes.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the EventTypes type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;

	using TFLogs.Events;

	/// <summary>
	/// The event types.
	/// </summary>
	public class EventTypes
	{
		/// <summary>
		/// The get all.
		/// </summary>
		/// <returns>
		/// The <see cref="List"/>.
		/// </returns>
		public static List<Type> GetAll()
		{
			return Assembly.GetAssembly(typeof(IEvent)).GetTypes().Where(t => typeof(IEvent).IsAssignableFrom(t) && !t.IsAbstract).ToList();
		}

		public static List<IEvent> GetInstancesOfAll()
		{
			List<IEvent> instances = new List<IEvent>();
			var types = GetAll();
			foreach (var type in types)
			{
				var instance = (IEvent)Activator.CreateInstance(type);
				instances.Add(instance);
			}
			return instances;
		}
	}
}
