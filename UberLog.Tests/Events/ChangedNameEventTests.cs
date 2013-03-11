// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangedNameEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the ChangedNameEventTests type.
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
	public class ChangedNameEventTests
	{
		[Theory, PropertyData("PlayerSteamIds")]
		public void PlayerSteamIdSetCorrectly(ChangedNameEvent evt, string steamId)
		{
			Assert.Equal(steamId, evt.Player.SteamId);
		}

		[Theory, PropertyData("OldNames")]
		public void OldNameSetCorrectly(ChangedNameEvent evt, string oldName)
		{
			Assert.Equal(oldName, evt.OldName);
		}

		[Theory, PropertyData("NewNames")]
		public void NewNameSetCorrectly(ChangedNameEvent evt, string newName)
		{
			Assert.Equal(newName, evt.NewName);
		}

		public static IEnumerable<object[]> PlayerSteamIds
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ChangedNameEvent>(l.LogText), l.SteamId });
			}
		}

		public static IEnumerable<object[]> OldNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ChangedNameEvent>(l.LogText), l.OldName });
			}
		}

		public static IEnumerable<object[]> NewNames
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ChangedNameEvent>(l.LogText), l.NewName });
			}
		}

		private static IEnumerable<ChangeNameEventInfo> Logs
		{
			get
			{
				return new List<ChangeNameEventInfo>
				{
					new ChangeNameEventInfo
					{
						LogText = "L 03/04/2013 - 20:21:05: \"scienide<19><STEAM_0:1:32215559><Blue>\" changed name to \"scienide .thc\"",
						SteamId = "STEAM_0:1:32215559",
						OldName = "scienide",
						NewName = "scienide .thc"
					}
				};
			}
		}

		private class ChangeNameEventInfo
		{
			public string LogText { get; set; }

			public string SteamId { get; set; }

			public string OldName { get; set; }

			public string NewName { get; set; }
		}
	}
}
