// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuildObjectEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the BuildObjectEventTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Linq;

	using UberLog;
	using UberLog.Events;
	using UberLog.Tests.Events;

	using Xunit;
	using Xunit.Extensions;

	[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
	public class BuildObjectEventTests
	{
		[Theory,
		PropertyData("BaseLogs")]
		public void SetsPlayer(BuiltObjectEvent buildObjectEvent)
		{
			Assert.NotNull(buildObjectEvent.Player);
		}

		[Theory,
		PropertyData("PlayerNames")]
		public void SetsPlayerName(BuiltObjectEvent buildObjectEvent, string playerName)
		{
			Assert.Equal(playerName, buildObjectEvent.Player.Name);
		}

		[Theory,
		PropertyData("PlayerSteamIds")]
		public void SetsPlayerSteamIdCorrectly(BuiltObjectEvent buildObjectEvent, string steamId)
		{
			Assert.Equal(steamId, buildObjectEvent.Player.SteamId);
		}

		[Theory,
		PropertyData("PlayerTeams")]
		public void SetsPlayerTeamCorrectly(BuiltObjectEvent buildObjectEvent, string teamName)
		{
			Assert.Equal(teamName, buildObjectEvent.Player.Team.Name);
		}

		[Theory,
		PropertyData("Positions")]
		public void SetsPositionCorrectly(BuiltObjectEvent buildObjectEvent, Position position)
		{
			Assert.Equal(position.X, buildObjectEvent.Position.X);
			Assert.Equal(position.Y, buildObjectEvent.Position.Y);
			Assert.Equal(position.Z, buildObjectEvent.Position.Z);
		}

		[Theory,
		PropertyData("ObjectsBuilt")]
		public void SetsObjectBuilt(BuiltObjectEvent buildObjectEvent, string objectName)
		{
			Assert.Equal(objectName, buildObjectEvent.ObjectBuilt.Name);
		}

		[Theory,
		PropertyData("EventTimes")]
		public void SetsDateTimeCorrectly(BuiltObjectEvent buildObjectEvent, DateTime expectedDate)
		{
			Assert.Equal(expectedDate, buildObjectEvent.EventTime);
		}

		public static IEnumerable<object[]> BaseLogs
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<BuiltObjectEvent>(l.LogText) });
			}
		}

		public static IEnumerable<object[]> PlayerNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<BuiltObjectEvent>(l.LogText), l.PlayerName });
			}
		}

		public static IEnumerable<object[]> PlayerSteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<BuiltObjectEvent>(l.LogText), l.SteamId });
			}
		}
			
		public static IEnumerable<object[]> PlayerTeams
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<BuiltObjectEvent>(l.LogText), l.TeamName });
			}
		}

		public static IEnumerable<object[]> Positions
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<BuiltObjectEvent>(l.LogText), l.Position });
			}
		}
		
		public static IEnumerable<object[]> ObjectsBuilt
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<BuiltObjectEvent>(l.LogText), l.ObjectName });
			}
		}

		public static IEnumerable<object[]> EventTimes
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<BuiltObjectEvent>(l.LogText), l.DateTime });
			}
		}

		private static List<LogInfo> Logs
		{
			get
			{
				return new List<LogInfo>
					           {
						           new LogInfo 
								   {
									   LogText = "L 03/04/2013 - 20:22:45: \"ranroll.esg<9><STEAM_0:1:10233891><Red>\" triggered \"builtobject\" (object \"OBJ_SENTRYGUN\") (position \"1561 -1420 -403\")",
									   ObjectName = "Sentry Gun",
									   PlayerName = "ranroll.esg",
									   SteamId = "STEAM_0:1:10233891",
									   TeamName = "RED",
									   Position = new Position { X = 1561, Y = -1420, Z = -403 },
									   DateTime = new DateTime(2013, 3, 4, 20, 22, 45)
								   },
						           new LogInfo
								   {
									   LogText = "L 03/04/2013 - 20:31:33: \"Eisen under new managment.<14><STEAM_0:0:17640804><Red>\" triggered \"builtobject\" (object \"OBJ_ATTACHMENT_SAPPER\") (position \"-528 -197 -223\")",
									   ObjectName = "Sapper",
									   TeamName = "RED",
									   PlayerName = "Eisen under new managment.",
									   SteamId = "STEAM_0:0:17640804",
									   Position = new Position { X = -528, Y = -197, Z = -223 },
									   DateTime = new DateTime(2013, 3, 4, 20, 31, 33)
								   },
								   new LogInfo
									{
										LogText = "L 03/04/2013 - 20:32:17: \"Danny-O.thc<17><STEAM_0:1:19665436><Blue>\" triggered \"builtobject\" (object \"OBJ_SENTRYGUN\") (position \"201 -3179 -570\")",
										DateTime = new DateTime(2013, 3, 4, 20, 32, 17),
										ObjectName = "Sentry Gun",
										PlayerName = "Danny-O.thc",
										Position = new Position { X = 201, Y = -3179, Z = -570 },
										SteamId = "STEAM_0:1:19665436",
										TeamName = "BLU"
									},
									new LogInfo
									{
										LogText = "L 03/04/2013 - 20:32:50: \"ranroll.esg<9><STEAM_0:1:10233891><Red>\" triggered \"builtobject\" (object \"OBJ_DISPENSER\") (position \"1546 -1069 -372\")",
										DateTime = new DateTime(2013, 3, 4, 20, 32, 50),
										ObjectName = "Dispenser",
										PlayerName = "ranroll.esg",
										Position = new Position { X = 1546, Y = -1069, Z = -372 },
										SteamId = "STEAM_0:1:10233891",
										TeamName = "RED"
									},
									new LogInfo
									{
										LogText = "L 03/04/2013 - 20:36:51: \"ranroll.esg<9><STEAM_0:1:10233891><Blue>\" triggered \"builtobject\" (object \"OBJ_TELEPORTER\") (position \"412 -3048 -575\")",
										DateTime = new DateTime(2013, 3, 4, 20, 36, 51),
										ObjectName = "Teleporter",
										PlayerName = "ranroll.esg",
										Position = new Position { X = 412, Y = -3048, Z = -575 },
										SteamId = "STEAM_0:1:10233891",
										TeamName = "BLU"
									}
					           };
			}
		}
		
		internal class LogInfo
		{
			public string LogText { get; set; }

			public string PlayerName { get; set; }

			public string TeamName { get; set; }

			public string ObjectName { get; set; }

			public string SteamId { get; set; }

			public Position Position { get; set; }

			public DateTime DateTime { get; set; }

			public BuiltObjectEvent BuildObjectEvent { get; set; }
		}
	}
}
