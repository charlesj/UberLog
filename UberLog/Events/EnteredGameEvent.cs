// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnteredGameEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The entered game event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The entered game event.
	/// </summary>
	public class EnteredGameEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EnteredGameEvent"/> class.
		/// </summary>
		public EnteredGameEvent()
		{
			this.Keystone = "entered the game";
			this.Name = "EnteredGame";
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
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetMatches();
			var playerString = matches[0].Value;
			this.Player = this.PlayerHelper(playerString);
			this.Player.Team = Team.GetFromCode("unassigned");
		}
	}
}