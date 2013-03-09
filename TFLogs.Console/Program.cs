// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Console
{
	using System;
	using System.IO;
	using System.Linq;

	using TFLogs.Events;

	/// <summary>
	/// The program.
	/// </summary>
	public class Program
	{
		/// <summary>
		/// The main.
		/// </summary>
		/// <param name="args">
		/// The args.
		/// </param>
		public static void Main(string[] args)
		{
			var logFile = GetLogFile();

			logFile.Parse();

			var eventTypes = EventTypes.GetAll();
			Console.WriteLine("Found {0} event types", eventTypes.Count);
			foreach (var eventType in eventTypes)
			{
				Console.WriteLine("Total {0}: {1}", eventType.Name, logFile.Events.Count(entry => entry.GetType() == eventType));
			}

			var uknowns = logFile.Events.Where(e => e.GetType() == typeof(UnknownEvent));
			foreach (var unknown in uknowns)
			{
				Console.WriteLine(unknown.RawText);
			}

			Console.ReadLine();
		}

		/// <summary>
		/// The get log file.
		/// </summary>
		/// <returns>
		/// The <see cref="LogFile"/>.
		/// </returns>
		public static LogFile GetLogFile()
		{
			var file = File.ReadAllText("tf.log");
			var lines = file.Split('\n');
			var entries = lines.Select(line => new UnparsedEvent { RawText = line }).ToList();
			return new LogFile { RawEvents = entries};
		}
	}
}
