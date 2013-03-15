// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DamageEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the DamageEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The damage event.
	/// </summary>
	public class DamageEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DamageEvent"/> class.
		/// </summary>
		public DamageEvent()
		{
			this.Keystone = "damage";
			this.Name = "Damage";
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
		/// Gets or sets the damage.
		/// </summary>
		public int Damage { get; set; }

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
			var damageString = matches[4].Value;

			this.Player = this.PlayerHelper(playerString);
			this.Damage = int.Parse(damageString);
		}
	}
}