// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtinguishedPlayerTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the ExtinguishedPlayerTests type.
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
	public class ExtinguishedPlayerTests
	{
		[Theory, PropertyData("SteamIds")]
		public void SetsSteamId(ExtinguishedPlayerEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.Player.SteamId);
		}

		[Theory, PropertyData("TargetSteamIds")]
		public void SetsTargetSteamId(ExtinguishedPlayerEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.TargetPlayer.SteamId);
		}

		[Theory, PropertyData("PlayerPositions")]
		public void SetsPlayerPosition(ExtinguishedPlayerEvent evt, Position position)
		{
			Assert.Equal(position.X, evt.PlayerPosition.X);
			Assert.Equal(position.Y, evt.PlayerPosition.Y);
			Assert.Equal(position.Z, evt.PlayerPosition.Z);
		}

		[Theory, PropertyData("TargetPositions")]
		public void SetsTargetPosition(ExtinguishedPlayerEvent evt, Position position)
		{
			Assert.Equal(position.X, evt.TargetPosition.X);
			Assert.Equal(position.Y, evt.TargetPosition.Y);
			Assert.Equal(position.Z, evt.TargetPosition.Z);
		}

		[Theory, PropertyData("WeaponNames")]
		public void SetsWeaponName(ExtinguishedPlayerEvent evt, string weaponName)
		{
			Assert.Equal(weaponName, evt.Weapon.Name);
		}

		public static IEnumerable<object[]> SteamIds
		{
			get
			{
				return
					Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ExtinguishedPlayerEvent>(l.LogText), l.PlayerSteamId });
			}
		}

		public static IEnumerable<object[]> TargetSteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ExtinguishedPlayerEvent>(l.LogText), l.TargetSteamId });
			}
		}

		public static IEnumerable<object[]> PlayerPositions
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ExtinguishedPlayerEvent>(l.LogText), l.PlayerPosition });
			}
		}

		public static IEnumerable<object[]> TargetPositions
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ExtinguishedPlayerEvent>(l.LogText), l.TargetPosition });
			}
		}

		public static IEnumerable<object[]> WeaponNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ExtinguishedPlayerEvent>(l.LogText), l.WeaponName });
			}
		}

		private static List<ExtinguishedPlayerInfo> Logs
		{
			get
			{
				return new List<ExtinguishedPlayerInfo>
					       {
						       new ExtinguishedPlayerInfo
							       {
								       LogText = "L 03/04/2013 - 20:39:19: \"Schrodinger<6><STEAM_0:1:26162903><Blue>\" triggered \"player_extinguished\" against \"Shamrock.esg<8><STEAM_0:0:545976><Blue>\" with \"tf_weapon_medigun\" (attacker_position \"91 -609 -223\") (victim_position \"342 -584 -143\")",
									   PlayerSteamId = "STEAM_0:1:26162903",
								       TargetSteamId = "STEAM_0:0:545976",
								       PlayerPosition = new Position { X = 91, Y = -609, Z = -223 },
								       TargetPosition = new Position { X = 342, Y = -584, Z = -143 },
								       WeaponName = "Medigun"
							       },
								   new ExtinguishedPlayerInfo
							       {
								       LogText = "L 03/04/2013 - 20:39:20: \"Enjuaguese<10><STEAM_0:1:28339662><Blue>\" triggered \"player_extinguished\" against \"Schrodinger<6><STEAM_0:1:26162903><Blue>\" with \"tf_weapon_flamethrower\" (attacker_position \"196 -504 -223\") (victim_position \"151 -567 -223\")",
									   PlayerSteamId = "STEAM_0:1:28339662",
								       TargetSteamId = "STEAM_0:1:26162903",
								       PlayerPosition = new Position { X = 196, Y = -504, Z = -223 }, 
								       TargetPosition = new Position { X = 151, Y = -567, Z = -223 },
								       WeaponName = "Flamethrower"
							       },
								   new ExtinguishedPlayerInfo
							       {
								       LogText = "L 03/04/2013 - 20:45:30: \"Clipshow Hughot!<12><STEAM_0:1:9430005><Blue>\" triggered \"player_extinguished\" against \"Clipshow Hughot!<12><STEAM_0:1:9430005><Blue>\" with \"tf_weapon_jar\" (attacker_position \"-1181 -1008 -158\") (victim_position \"-1181 -1008 -158\")",
									   PlayerSteamId = "STEAM_0:1:9430005",
								       TargetSteamId = "STEAM_0:1:9430005",
								       PlayerPosition = new Position { X = -1181, Y = -1008, Z = -158 }, 
								       TargetPosition = new Position { X = -1181, Y = -1008, Z = -158 },
								       WeaponName = "Jar"
							       }
					       };
			}
		}

		private class ExtinguishedPlayerInfo
		{
			public string LogText { get; set; }

			public string PlayerSteamId { get; set; }

			public string TargetSteamId { get; set; }

			public Position PlayerPosition { get; set; }

			public Position TargetPosition { get; set; }

			public string WeaponName { get; set; }
		}
	}
}
