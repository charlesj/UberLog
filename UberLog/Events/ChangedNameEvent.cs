// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangedNameEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The changed name event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The changed name event.
	/// </summary>
	public class ChangedNameEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChangedNameEvent"/> class.
		/// </summary>
		public ChangedNameEvent()
		{
			this.Keystone = "changed name";
			this.Name = "ChangedName";
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
		/// Gets or sets the new name.
		/// </summary>
		public string NewName { get; set; }

		/// <summary>
		/// Gets or sets the old name.
		/// </summary>
		public string OldName { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetRegexMatches();
			var playerString = matches[0].Value;
			var newNameString = matches[2].Value;

		    this.Player = this.PlayerHelper(playerString);
			this.NewName = newNameString;
			this.OldName = this.Player.Name;
		}
	}
}