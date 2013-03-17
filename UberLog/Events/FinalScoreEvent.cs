// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FinalScoreEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The file score event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The file score event.
	/// </summary>
	public class FinalScoreEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FinalScoreEvent"/> class.
		/// </summary>
		public FinalScoreEvent()
		{
			this.Keystone = "final score";
			this.Name = "FinalScore";
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
		/// Gets or sets the team.
		/// </summary>
		public Team Team { get; set; }

		/// <summary>
		/// Gets or sets the score.
		/// </summary>
		public int Score { get; set; }

		/// <summary>
		/// Gets or sets the player count.
		/// </summary>
		public int PlayerCount { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetMatches();
			var teamString = matches[0].Value;
			var scoreString = matches[2].Value;
			var playerCountString = matches[4].Value;

			this.Team = Team.GetFromCode(teamString);
			this.Score = int.Parse(scoreString);
			this.PlayerCount = int.Parse(playerCountString);
		}
	}
}