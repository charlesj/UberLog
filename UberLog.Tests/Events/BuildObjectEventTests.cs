// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuildObjectEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the BuildObjectEventTests type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Linq;

	using UberLog;
	using UberLog.Events;

	using Xunit;
	using Xunit.Extensions;

	[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
	public class BuildObjectEventTests
	{
		[Theory,
		PropertyData("BaseLogs")]
		public void SetsPlayer(string logText)
		{
			var buildObjectEvent = new BuiltObjectEvent { RawText = logText };
			buildObjectEvent.Parse();
			Assert.NotNull(buildObjectEvent.Player);
		}

		[Theory,
		PropertyData("PlayerName")]
		public void SetsPlayerName(string logText, string playerName)
		{
			var buildObjectEvent = new BuiltObjectEvent { RawText = logText };
			buildObjectEvent.Parse();
			Assert.Equal(playerName, buildObjectEvent.Player.Name);
		}

		[Theory,
		PropertyData("PlayerSteamIds")]
		public void SetsPlayerSteamIdCorrectly(string logText, string steamId)
		{
			var buildObjectEvent = new BuiltObjectEvent { RawText = logText };
			buildObjectEvent.Parse();
			Assert.Equal(steamId, buildObjectEvent.Player.SteamId);
		}

		[Theory,
		PropertyData("PlayerTeams")]
		public void SetsPlayerTeamCorrectly(string logText, Team team)
		{
			var buildObjectEvent = new BuiltObjectEvent { RawText = logText };
			buildObjectEvent.Parse();
			Assert.Equal(team, buildObjectEvent.Player.Team);
		}

		[Theory,
		PropertyData("Positions")]
		public void SetsPositionCorrectly(string logText, Position position)
		{
			var buildObjectEvent = new BuiltObjectEvent { RawText = logText };
			buildObjectEvent.Parse();

			Assert.Equal(position.X, buildObjectEvent.Position.X);
			Assert.Equal(position.Y, buildObjectEvent.Position.Y);
			Assert.Equal(position.Z, buildObjectEvent.Position.Z);
		}

		[Theory,
		PropertyData("ObjectsBuilt")]
		public void SetsObjectBuilt(string logText, string objectName)
		{
			var buildObjectEvent = new BuiltObjectEvent { RawText = logText };
			buildObjectEvent.Parse();
			Assert.Equal(objectName, buildObjectEvent.ObjectBuilt.Name);
		}

		[Fact]
		public void SetsDateTimeCorrectly()
		{
			var buildObjectEvent = new BuiltObjectEvent { RawText = Logs[0] };
			buildObjectEvent.Parse();
			var expectedDate = new DateTime(2013, 3, 4, 20, 22, 45);
			Assert.Equal(expectedDate, buildObjectEvent.EventTime);
		}

		public static IEnumerable<object[]> BaseLogs
		{
			get
			{
				return Logs.Select(l => new object[] { l });
			}
		}

		public static IEnumerable<object[]> PlayerName
		{
			get
			{
				var rtn = new List<object[]>();
				rtn.Add(new object[] { Logs[0], "ranroll.esg" });
				rtn.Add(new object[] { Logs[1], "Eisen under new managment." });
				return rtn;
			}
		}

		public static IEnumerable<object[]> PlayerSteamIds
		{
			get
			{
				var rtn = new List<object[]>();
				rtn.Add(new object[] { Logs[0], "STEAM_0:1:10233891" });
				rtn.Add(new object[] { Logs[1], "STEAM_0:0:17640804" });
				return rtn;
			}
		}
			
		public static IEnumerable<object[]> PlayerTeams
		{
			get
			{
				var rtn = new List<object[]>();
				rtn.Add(new object[] { Logs[0], Team.RED });
				rtn.Add(new object[] { Logs[1], Team.RED });
				return rtn;
			}
		}

		public static IEnumerable<object[]> Positions
		{
			get
			{
				var rtn = new List<object[]>();
				rtn.Add(new object[] { Logs[0], new Position { X = 1561, Y = -1420, Z = -403 } });
				rtn.Add(new object[] { Logs[1], new Position { X = -528, Y = -197, Z = -223 } });
				return rtn;
			}
		}
		
		public static IEnumerable<object[]> ObjectsBuilt
		{
			get
			{
				var rtn = new List<object[]>();
				rtn.Add(new object[] { Logs[0], "Sentry Gun" });
				rtn.Add(new object[] { Logs[1], "Sapper" });
				return rtn;
			}
		}

		private static List<string> Logs
		{
			get
			{
				return new List<string>
					           {
						           "L 03/04/2013 - 20:22:45: \"ranroll.esg<9><STEAM_0:1:10233891><Red>\" triggered \"builtobject\" (object \"OBJ_SENTRYGUN\") (position \"1561 -1420 -403\")",
						           "L 03/04/2013 - 20:31:33: \"Eisen under new managment.<14><STEAM_0:0:17640804><Red>\" triggered \"builtobject\" (object \"OBJ_ATTACHMENT_SAPPER\") (position \"-528 -197 -223\")"
					           };
			}
		}
	}
}
