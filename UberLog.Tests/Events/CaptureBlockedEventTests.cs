// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaptureBlockedEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the CaptureBlockedEventTests type.
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
	public class CaptureBlockedEventTests
	{
		[Theory, PropertyData("PlayerNames")]
		public void PlayerNamesSetCorrectly(CaptureBlockedEvent evt, string playerName)
		{
			Assert.Equal(playerName, evt.Player.Name);
		}

		[Theory, PropertyData("PlayerSteamIds")]
		public void PlayerSteamIdsSetCorrectly(CaptureBlockedEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.Player.SteamId);
		}

		[Theory, PropertyData("PointNumbers")]
		public void PointNumberSetCorrectly(CaptureBlockedEvent evt, int pointNumber)
		{
			Assert.Equal(pointNumber, evt.PointNumber);
		}

		[Theory, PropertyData("PointNames")]
		public void PointNamesSetCorrectly(CaptureBlockedEvent evt, string name)
		{
			Assert.Equal(name, evt.PointName);
		}

		[Theory, PropertyData("Positions")]
		public void PositionsSetCorrectly(CaptureBlockedEvent evt, Position position)
		{
			Assert.Equal(position.X, evt.Position.X);
			Assert.Equal(position.Y, evt.Position.Y);
			Assert.Equal(position.Z, evt.Position.Z);
		}

		public static IEnumerable<object[]> Positions
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<CaptureBlockedEvent>(l.LogText), l.Position });
			}
		}

		public static IEnumerable<object[]> PointNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<CaptureBlockedEvent>(l.LogText), l.PointName });
			}
		}

		public static IEnumerable<object[]> PointNumbers
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<CaptureBlockedEvent>(l.LogText), l.PointNumber });
			}
		}

		public static IEnumerable<object[]> PlayerSteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<CaptureBlockedEvent>(l.LogText), l.SteamId });
			}
		}

		public static IEnumerable<object[]> PlayerNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<CaptureBlockedEvent>(l.LogText), l.PlayerName });
			}
		}

		private static List<CaptureBlockedInfo> Logs
		{
			get
			{
				return new List<CaptureBlockedInfo>
				{
					new CaptureBlockedInfo
					{
						LogText = "L 03/04/2013 - 20:28:49: \"radio.esg<11><STEAM_0:1:38993395><Red>\" triggered \"captureblocked\" (cp \"4\") (cpname \"Cap E, The main point\") (position \"624 125 -219\")",
						PlayerName = "radio.esg",
						SteamId = "STEAM_0:1:38993395",
						PointNumber = 4,
						PointName = "Cap E, The main point",
						Position = new Position { X = 624, Y = 125, Z = -219 }
					},
					new CaptureBlockedInfo
					{
						LogText = "L 03/04/2013 - 20:32:33: \"honahursey<4><STEAM_0:0:15444288><Red>\" triggered \"captureblocked\" (cp \"1\") (cpname \"Cap B, the Red Shed spawn\") (position \"1948 -837 -223\")",
						PlayerName = "honahursey",
						SteamId = "STEAM_0:0:15444288",
						PointNumber = 1,
						PointName = "Cap B, the Red Shed spawn",
						Position = new Position { X = 1948, Y = -837, Z = -223 }
					}
				};
			}
		}

		private class CaptureBlockedInfo
		{
			public string LogText { get; set; }

			public Position Position { get; set; }

			public string PointName { get; set; }

			public int PointNumber { get; set; }

			public string SteamId { get; set; }

			public string PlayerName { get; set; }
		}
	}
}
