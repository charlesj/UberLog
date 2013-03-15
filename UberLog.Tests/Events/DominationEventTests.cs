// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DominationEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the DominationEventTests type.
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
	public class DominationEventTests
	{
		[Theory, PropertyData("SteamIds")]
		public void SetsPlayerId(DominationEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.Player.SteamId);
		}

		[Theory, PropertyData("DominatedSteamIds")]
		public void SetsDominatedPlayerId(DominationEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.DominatedPlayer.SteamId);
		}

		public static IEnumerable<object[]> SteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<DominationEvent>(l.LogText), l.PlayerSteamId });
			}
		}

		public static IEnumerable<object[]> DominatedSteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<DominationEvent>(l.LogText), l.DominatedPlayerSteamId });
			}
		}

		private static List<DominationEventInfo> Logs
		{
			get
			{
				return new List<DominationEventInfo>
					       {
						       new DominationEventInfo
							       {
								       LogText = "L 03/04/2013 - 20:35:04: \"radio.esg<11><STEAM_0:1:38993395><Red>\" triggered \"domination\" against \"Sputnik.thc<3><STEAM_0:0:42495040><Blue>\"",
									   PlayerSteamId = "STEAM_0:1:38993395",
									   DominatedPlayerSteamId = "STEAM_0:0:42495040"
							       }
					       };
			}
		}

		private class DominationEventInfo
		{
			public string LogText { get; set; }

			public string PlayerSteamId { get; set; }

			public string DominatedPlayerSteamId { get; set; }
		}
	}
}
