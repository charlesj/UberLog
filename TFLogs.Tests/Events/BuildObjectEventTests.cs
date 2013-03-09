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
		public class BuiltObjectEventTestsWithTeleporter
		{
			private const string Text = "L 03/04/2013 - 20:31:05: \"Danny-O.thc<17><STEAM_0:1:19665436><Blue>\" triggered \"builtobject\" (object \"OBJ_TELEPORTER\") (position \"-481 -159 -223\")";

			[Fact]
			public void BuildObjectEventsSetsPlayer()
			{
				var buildObjectEvent = new BuiltObjectEvent { RawText = Text };
				buildObjectEvent.Parse();
				Assert.NotNull(buildObjectEvent.Player);
			}

			[Fact]
			public void BuiltObjectEventSetsPlayerNameCorrectly()
			{
				var buildObjectEvent = new BuiltObjectEvent { RawText = Text };
				buildObjectEvent.Parse();
				Assert.Equal("Danny-O.thc", buildObjectEvent.Player.Name);
			}
		}
    }
}
