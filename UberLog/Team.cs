// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Team.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The team.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog
{
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	///     The team.
	/// </summary>
	public class Team
	{
		/// <summary>
		/// The all teams.
		/// </summary>
		private static List<Team> allTeams;

		/// <summary>
		/// Initializes static members of the <see cref="Team"/> class.
		/// </summary>
		static Team()
		{
			allTeams = new List<Team>
				    {
					    new Team { Name = "RED", Code = "Red" },
					    new Team { Name = "BLU", Code = "Blue" },
					    new Team { Name = "Unknown", Code = "unknown" },
					    new Team { Name = "Unassigned", Code = "unassigned" },
					    new Team { Name = "Spectator", Code = "spectator" }
				    };
		}

		/// <summary>
		/// Prevents a default instance of the <see cref="Team"/> class from being created.
		/// </summary>
		private Team()
		{
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		public string Code { get; set; }

		/// <summary>
		/// The get from code.
		/// </summary>
		/// <param name="code">
		/// The code.
		/// </param>
		/// <returns>
		/// The <see cref="Team"/>.
		/// </returns>
		public static Team GetFromCode(string code)
		{
			if (allTeams.All(team => team.Code != code))
			{
				code = "unknown";
			}

			return allTeams.Single(team => team.Code == code);
		}
	}
}