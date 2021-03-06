﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Player.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the Player type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog
{
	using System.Text.RegularExpressions;

	/// <summary>
	/// The player.
	/// </summary>
	public class Player
	{
		/// <summary>
		/// Gets or sets the raw text.
		/// </summary>
		public string RawText { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the steam id.
		/// </summary>
		public string SteamId { get; set; }

		/// <summary>
		/// Gets or sets the team.
		/// </summary>
		public Team Team { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public void Parse()
		{
			var noquote = this.RawText.Replace("\"", string.Empty);
			var angleRegex = new Regex("(?<=<)(.*?)(?=>)");
			var matches = angleRegex.Matches(noquote); // should be 3 matches
			this.Name = noquote.Substring(0, noquote.IndexOf('<'));
			this.SteamId = matches[1].Value; 
			var team = matches[2].Value;
			this.Team = Team.GetFromCode(team);
		}
	}
}
