// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FinalScoreEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the FinalScoreEventTests type.
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
	public class FinalScoreEventTests
	{
		[Theory, PropertyData("TeamNames")]
		public void SetsTeam(FinalScoreEvent evt, string teamName)
		{
			Assert.Equal(teamName, evt.Team.Name);
		}

		[Theory, PropertyData("Scores")]
		public void SetsScore(FinalScoreEvent evt, int score)
		{
			Assert.Equal(score, evt.Score);
		}

		[Theory, PropertyData("NumPlayers")]
		public void SetsNumPlayers(FinalScoreEvent evt, int numPlayers)
		{
			Assert.Equal(numPlayers, evt.PlayerCount);
		}

		public static IEnumerable<object[]> TeamNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<FinalScoreEvent>(l.LogText), l.TeamName });
			}
		}

		public static IEnumerable<object[]> Scores
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<FinalScoreEvent>(l.LogText), l.Score });
			}
		}

		public static IEnumerable<object[]> NumPlayers
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<FinalScoreEvent>(l.LogText), l.NumPlayers });
			}
		}

		private static List<FinalScoreInfo> Logs
		{
			get
			{
				return new List<FinalScoreInfo>
					       {
						       new FinalScoreInfo
							       {
								       LogText = "L 03/04/2013 - 20:40:06: Team \"Red\" final score \"0\" with \"9\" players",
									   TeamName = "RED",
									   Score = 0,
									   NumPlayers = 9
							       },
								   new FinalScoreInfo
							       {
								       LogText = "L 03/04/2013 - 20:40:06: Team \"Blue\" final score \"5\" with \"8\" players",
									   TeamName = "BLU",
									   Score = 5,
									   NumPlayers = 8
							       }
					       };
			}
		}

		private class FinalScoreInfo
		{
			public string LogText { get; set; }

			public string TeamName { get; set; }

			public int Score { get; set; }

			public int NumPlayers { get; set; }
		}
	}
}
