// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtinguishedPlayer.cs" company="Josh Charles">
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
	public class ExtinguishedPlayer : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ExtinguishedPlayer"/> class.
		/// </summary>
		public ExtinguishedPlayer()
		{
			this.Keystone = "player_extinguished";
			this.Name = "ExtinguishedPlayer";
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