// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameOverEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The game over event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The game over event.
	/// </summary>
	public class GameOverEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GameOverEvent"/> class.
		/// </summary>
		public GameOverEvent()
		{
			this.Keystone = "Game_Over";
			this.Name = "GameOver";
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
		/// Gets or sets the reason.
		/// </summary>
		public string Reason { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetMatches();
			this.Reason = matches[2].Value;
		}
	}
}