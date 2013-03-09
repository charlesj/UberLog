// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileScoreEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The file score event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The file score event.
	/// </summary>
	public class FileScoreEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FileScoreEvent"/> class.
		/// </summary>
		public FileScoreEvent()
		{
			this.Keystone = "final score";
			this.Name = "FinalScore";
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