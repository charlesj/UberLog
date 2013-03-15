// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DominationEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the DominationEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The domination event.
	/// </summary>
	public class DominationEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DominationEvent"/> class.
		/// </summary>
		public DominationEvent()
		{
			this.Keystone = "domination";
			this.Name = "Domination";
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
		/// Gets or sets the player.
		/// </summary>
		public Player Player { get; set; }

		/// <summary>
		/// Gets or sets the dominated player.
		/// </summary>
		public Player DominatedPlayer { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetMatches();
			var playerString = matches[0].Value;
			var domPlayerString = matches[4].Value;

			this.Player = this.PlayerHelper(playerString);
			this.DominatedPlayer = this.PlayerHelper(domPlayerString);
		}
	}
}