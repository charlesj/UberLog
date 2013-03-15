// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DamageEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the DamageEventTests type.
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
	public class DamageEventTests
	{
		[Theory, PropertyData("Damages")]
		public void SetsDamage(DamageEvent evt, int damage)
		{
			Assert.Equal(damage, evt.Damage);
		}

		[Theory, PropertyData("SteamIds")]
		public void SetsPlayerSteamId(DamageEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.Player.SteamId);
		}

		public static IEnumerable<object[]> Damages
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<DamageEvent>(l.LogText), l.DamageAmount });
			}
		}

		public static IEnumerable<object[]> SteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<DamageEvent>(l.LogText), l.SteamId });
			}
		}

		private static IEnumerable<DamageEventInfo> Logs
		{
			get
			{
				return new List<DamageEventInfo>
				{
					new DamageEventInfo
					{
						LogText = "L 03/04/2013 - 20:17:47: \"ranroll.esg<9><STEAM_0:1:10233891><Red>\" triggered \"damage\" (damage \"3\")",
						SteamId = "STEAM_0:1:10233891",
						DamageAmount = 3
					},
					new DamageEventInfo
					{
						LogText = "L 03/04/2013 - 20:18:10: \"Toast<2><STEAM_0:1:12365159><Blue>\" triggered \"damage\" (damage \"105\")",
						SteamId = "STEAM_0:1:12365159",
						DamageAmount = 105
					}
				};
			}
		}

		private class DamageEventInfo
		{
			public string LogText { get; set; }

			public string SteamId { get; set; }

			public int DamageAmount { get; set; }
		}
	}
}
