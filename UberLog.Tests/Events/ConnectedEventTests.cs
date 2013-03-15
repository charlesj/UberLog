// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectedEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the ConnectedEventTests type.
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
	public class ConnectedEventTests
	{
		[Theory, PropertyData("Addresses")]
		public void SetsSteamId(ConnectedEvent evt, string address)
		{
			Assert.NotNull(evt.Player);
		}

		[Theory, PropertyData("Addresses")]
		public void SetsAddress(ConnectedEvent evt, string address)
		{
			Assert.Equal(address, evt.Address);
		}

		public static IEnumerable<object[]> Addresses
		{
			get
			{
				return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ConnectedEvent>(l.LogText), l.Address });
			}
		}

		private static List<ConnectedEventInfo> Logs
		{
			get
			{
				return new List<ConnectedEventInfo>
					       {
						       new ConnectedEventInfo
							       {
								       LogText = "L 03/04/2013 - 20:16:44: \"Schrodinger<6><STEAM_0:1:26162903><>\" connected, address \"0.0.0.0:27005\"",
									   Address = "0.0.0.0:27005"
							       }
					       };
			}
		}

		private class ConnectedEventInfo
		{
			public string LogText { get; set; }

			public string Address { get; set; }
		}
	}
}
