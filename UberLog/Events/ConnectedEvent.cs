// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The connected event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The connected event.
	/// </summary>
	public class ConnectedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConnectedEvent"/> class.
		/// </summary>
		public ConnectedEvent()
		{
			this.Keystone = "connected";
			this.Name = "Connected";
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
		/// Gets or sets the address.
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetMatches();
			var playerString = matches[0].Value;
			var addressString = matches[2].Value;

			this.Player = this.PlayerHelper(playerString);
			this.Address = addressString;
		}
	}
}