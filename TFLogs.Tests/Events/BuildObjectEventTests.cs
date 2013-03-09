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
	using System.Diagnostics.CodeAnalysis;

	using TFLogs.Events;

	using Xunit;

	[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
	public class BuildObjectEventTests
    {
		public class BuiltObjectEventTestsWithSentry
		{
			private string text = "L 03/04/2013 - 20:22:45: \"ranroll.esg<9><STEAM_0:1:10233891><Red>\" triggered \"builtobject\" (object \"OBJ_SENTRYGUN\") (position \"1561 -1420 -403\")";

			[Fact]
			public void SetsPlayer()
			{
				var buildObjectEvent = new BuiltObjectEvent { RawText = this.text };
				buildObjectEvent.Parse();
				Assert.NotNull(buildObjectEvent.Player);
			}

			[Fact]
			public void SetsPlayerNameCorrectly()
			{
				var buildObjectEvent = new BuiltObjectEvent { RawText = this.text };
				buildObjectEvent.Parse();
				Assert.Equal("ranroll.esg", buildObjectEvent.Player.Name);
			}

			[Fact]
			public void SetsPlayerSteamIdCorrectly()
			{
				var buildObjectEvent = new BuiltObjectEvent { RawText = this.text };
				buildObjectEvent.Parse();
				Assert.Equal("STEAM_0:1:10233891", buildObjectEvent.Player.SteamId);
			}

			[Fact]
			public void SetsPlayerTeamCorrectly()
			{
				var buildObjectEvent = new BuiltObjectEvent { RawText = this.text };
				buildObjectEvent.Parse();
				Assert.Equal(Team.RED, buildObjectEvent.Player.Team);
			}

			[Fact]
			public void SetsPositionCorrectly()
			{
				var buildObjectEvent = new BuiltObjectEvent { RawText = this.text };
				buildObjectEvent.Parse();
				var position = new Position { X = 1561, Y = -1420, Z = -403 };
				Assert.Equal(position.X, buildObjectEvent.Position.X);
				Assert.Equal(position.Y, buildObjectEvent.Position.Y);
				Assert.Equal(position.Z, buildObjectEvent.Position.Z);
			}
		}
    }
}
