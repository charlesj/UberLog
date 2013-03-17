// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameOverEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the GameOverEventTests type.
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
	public class GameOverEventTests
	{
		[Theory, PropertyData("Reasons")]
		public void SetsReason(GameOverEvent evt, string reason)
		{
			Assert.Equal(reason, evt.Reason);
		}

		public static IEnumerable<object[]> Reasons
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<GameOverEvent>(l.LogText), l.Reason });
			}
		}

		private static List<GameOverInfo> Logs
		{
			get
			{
				return new List<GameOverInfo>
				{
					new GameOverInfo
					{
						LogText = "L 03/04/2013 - 20:40:06: World triggered \"Game_Over\" reason \"Reached Round Limit\"",
						Reason = "Reached Round Limit"
					}
				};
			}
		}

		private class GameOverInfo 
		{
			public string LogText { get; set; }

			public string Reason { get; set; }
		}
	}
}
