// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChoseClassEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the ChoseClassEventTests type.
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
	public class ChoseClassEventTests
	{
		[Theory, PropertyData("PlayerSteamIds")]
		public void SetsSteamId(ChoseClassEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.Player.SteamId);
		}

		[Theory, PropertyData("ClassNames")]
		public void SetsChosenClass(ChoseClassEvent evt, string className)
		{
			Assert.Equal(className, evt.PlayerClass.Name);
		}

		public static IEnumerable<object[]> PlayerSteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ChoseClassEvent>(l.RawText), l.SteamId });
			}
		}

		public static IEnumerable<object[]> ClassNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ChoseClassEvent>(l.RawText), l.ClassName });
			}
		}

		private static List<ChoseClassEventInfo> Logs
		{
			get
			{
				return new List<ChoseClassEventInfo>
				{
					new ChoseClassEventInfo 
					{ 
						RawText = "L 03/04/2013 - 20:57:42: \"ranroll.esg<9><STEAM_0:1:10233891><Red>\" changed role to \"soldier\"",
						SteamId = "STEAM_0:1:10233891", 
						ClassName = "Soldier"
					},					
					new ChoseClassEventInfo 
					{ 
						RawText = "L 03/04/2013 - 20:17:15: \"Schrodinger<6><STEAM_0:1:26162903><Red>\" changed role to \"medic\"",
						SteamId = "STEAM_0:1:26162903", 
						ClassName = "Medic"
					},
					new ChoseClassEventInfo 
					{ 
						RawText = "L 03/04/2013 - 20:54:48: \"Eisen under new managment.<14><STEAM_0:0:17640804><Red>\" changed role to \"demoman\"",
						SteamId = "STEAM_0:0:17640804", 
						ClassName = "Demoman"
					}
				};
			}
		}

		private class ChoseClassEventInfo
		{
			public string RawText { get; set; }

			public string SteamId { get; set; }

			public string ClassName { get; set; }
		}
	}
}
