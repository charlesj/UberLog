// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoundStartEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The round start event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The round start event.
	/// </summary>
	public class RoundStartEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RoundStartEvent"/> class.
		/// </summary>
		public RoundStartEvent()
		{
			this.Keystone = "Round_Start";
			this.Name = "RoundStart";
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