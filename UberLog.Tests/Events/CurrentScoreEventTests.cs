// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CurrentScoreEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the CurrentScoreEventTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Tests.Events
{
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Linq;

	using UberLog.Events;

	using Xunit;
	using Xunit.Extensions;

	[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
	public class CurrentScoreEventTests
	{
		[Theory, PropertyData("TeamNames")]
		public void SetsTeamName(CurrentScoreEvent evt, string teamName)
		{
			Assert.Equal(teamName, evt.Team.Name);
		}

		[Theory, PropertyData("Scores")]
		public void SetsScore(CurrentScoreEvent evt, int score)
		{
			Assert.Equal(score, evt.Score);
		}

		[Theory, PropertyData("PlayerCounts")]
		public void SetsNumPlayers(CurrentScoreEvent evt, int playerCount)
		{
			Assert.Equal(playerCount, evt.PlayerCount);
		}

		public static IEnumerable<object[]> TeamNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<CurrentScoreEvent>(l.LogText), l.TeamName });
			}
		}

		public static IEnumerable<object[]> Scores
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<CurrentScoreEvent>(l.LogText), l.Score });
			}
		}

		public static IEnumerable<object[]> PlayerCounts
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<CurrentScoreEvent>(l.LogText), l.PlayerCount });
			}
		}

		private static IEnumerable<CurrentScoreInfo> Logs
		{
			get
			{
				return new List<CurrentScoreInfo>
				{
					new CurrentScoreInfo
					{
						LogText = "L 03/04/2013 - 20:36:10: TeamName \"Red\" current score \"0\" with \"9\" players",
						TeamName = "RED",
						Score = 0,
						PlayerCount = 9
					},
					new CurrentScoreInfo
					{
						LogText = "L 03/04/2013 - 20:36:10: TeamName \"Blue\" current score \"5\" with \"9\" players",
						TeamName = "BLU",
						Score = 5,
						PlayerCount = 9
					}
				};
			}
		}

		private class CurrentScoreInfo
		{
			public string LogText { get; set; }

			public string TeamName { get; set; }

			public int Score { get; set; }

			public int PlayerCount { get; set; }
		}
	}
}
