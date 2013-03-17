// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HealEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the HealEventTests type.
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
	public class HealEventTests
	{
		[Theory, PropertyData("SteamIds")]
		public void SetsSteamId(HealEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.Player.SteamId);
		}

		[Theory, PropertyData("TargetSteamIds")]
		public void SetsTargetSteamId(HealEvent evt, string targetSteamId)
		{
			Assert.Equal(targetSteamId, evt.TargetPlayer.SteamId);
		}

		[Theory, PropertyData("Amounts")]
		public void SetsAmounts(HealEvent evt, int amount)
		{
			Assert.Equal(amount, evt.Amount);
		}

		public static IEnumerable<object[]> SteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<HealEvent>(l.LogText), l.PlayerSteamId });
			}
		}

		public static IEnumerable<object[]> TargetSteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<HealEvent>(l.LogText), l.TargetSteamId });
			}
		}

		public static IEnumerable<object[]> Amounts
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<HealEvent>(l.LogText), l.Amount });
			}
		}

		private static List<HealInfo> Logs
		{
			get
			{
				return new List<HealInfo>
				{
					new HealInfo
					{
						LogText = "L 03/04/2013 - 20:44:40: \"Schrodinger.esg<6><STEAM_0:1:26162903><Blue>\" triggered \"healed\" against \"Toast<2><STEAM_0:1:12365159><Blue>\" (healing \"26\")",
						PlayerSteamId = "STEAM_0:1:26162903",
						TargetSteamId = "STEAM_0:1:12365159",
						Amount = 26
					},
					new HealInfo
					{
						LogText = "L 03/04/2013 - 20:44:54: \"Schrodinger.esg<6><STEAM_0:1:26162903><Blue>\" triggered \"healed\" against \"Shamrock.esg<8><STEAM_0:0:545976><Blue>\" (healing \"3\")",
						PlayerSteamId = "STEAM_0:1:26162903",
						TargetSteamId = "STEAM_0:0:545976",
						Amount = 3
					}
				};
			}
		}

		private class HealInfo
		{
			public string LogText { get; set; }

			public string PlayerSteamId { get; set; }

			public string TargetSteamId { get; set; }

			public int Amount { get; set; }
		}
	}
}
