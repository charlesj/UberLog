// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EnteredGameEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the EnteredGameEventTests type.
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
	public class EnteredGameEventTests
	{
		[Theory, PropertyData("SteamIds")]
		public void SetsSteamId(EnteredGameEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.Player.SteamId);
		}

		[Theory, PropertyData("SteamIds")]
		public void SetsUnassignedTeam(EnteredGameEvent evt, string steamId)
		{
			Assert.Equal("Unassigned", evt.Player.Team.Name);
		}

		public static IEnumerable<object[]> SteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<EnteredGameEvent>(l.LogText), l.SteamId });
			}
		}

		private static IEnumerable<EnteredGameEventInfo> Logs
		{
			get
			{
				return new List<EnteredGameEventInfo>
				{
					new EnteredGameEventInfo
					{
						LogText = "L 03/04/2013 - 20:58:16: \"radio.esg<21><STEAM_0:1:38993395><>\" entered the game",
						SteamId = "STEAM_0:1:38993395"
					}
				};
			}
		}

		private class EnteredGameEventInfo
		{
			public string LogText { get; set; }

			public string SteamId { get; set; }
		}
	}
}
