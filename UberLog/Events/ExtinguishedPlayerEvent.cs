// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtinguishedPlayerEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The extinguished player.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The extinguished player.
	/// </summary>
	public class ExtinguishedPlayerEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExtinguishedPlayerEvent"/> class.
		/// </summary>
		public ExtinguishedPlayerEvent()
		{
			this.Keystone = "player_extinguished";
			this.Name = "ExtinguishedPlayerEvent";
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
		/// Gets or sets the target player.
		/// </summary>
		public Player TargetPlayer { get; set; }

		public Position PlayerPosition { get; set; }

		public Position TargetPosition { get; set; }

		public GameObject Weapon { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetMatches();
			var playerString = matches[0].Value;
			var targetString = matches[4].Value;
			var positionString = matches[8].Value;
			var targetPositionString = matches[10].Value;
			var weaponString = matches[6].Value;

			this.Player = this.PlayerHelper(playerString);
			this.TargetPlayer = this.PlayerHelper(targetString);
			this.PlayerPosition = this.PositionHelper(positionString);
			this.TargetPosition = this.PositionHelper(targetPositionString);
			this.Weapon = GameObject.Get(weaponString);
		}
	}
}