// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HealEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The heal event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The heal event.
	/// </summary>
	public class HealEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HealEvent"/> class.
		/// </summary>
		public HealEvent()
		{
			this.Keystone = "healed";
			this.Name = "Heal";
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
		/// Gets or sets the player giving the heals.
		/// </summary>
		public Player Player { get; set; }

		/// <summary>
		/// Gets or sets the target player receiving the heals.
		/// </summary>
		public Player TargetPlayer { get; set; }

		/// <summary>
		/// Gets or sets the amount healed.
		/// </summary>
		public int Amount { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetMatches();
			var playerString = matches[0].Value;
			var targetString = matches[4].Value;
			var amountString = matches[6].Value;

			this.Player = this.PlayerHelper(playerString);
			this.TargetPlayer = this.PlayerHelper(targetString);
			this.Amount = int.Parse(amountString);
		}
	}
}