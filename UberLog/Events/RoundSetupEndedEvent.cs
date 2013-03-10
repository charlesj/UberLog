// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoundSetupEndedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The round setup ended event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The round setup ended event.
	/// </summary>
	public class RoundSetupEndedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RoundSetupEndedEvent"/> class.
		/// </summary>
		public RoundSetupEndedEvent()
		{
			this.Keystone = "Round_Setup_End";
			this.Name = "RoundSetupEnd";
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