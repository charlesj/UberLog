// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatEventTests.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the ChatEventTests type.
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
    public class ChatEventTests
    {
        [Theory, PropertyData("PlayerSteamIds")]
        public void PlayerSteamIdSetCorrectly(ChatEvent evt, string steamId)
        {
            Assert.Equal(steamId, evt.Player.SteamId);
        }

        [Theory, PropertyData("Messages")]
        public void MessageSetCorrectly(ChatEvent evt, string message)
        {
            Assert.Equal(message, evt.Message);
        }

        public static IEnumerable<object[]> Messages
        {
            get
            {
                return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ChatEvent>(l.LogText), l.Message });
            }
        }

        public static IEnumerable<object[]> PlayerSteamIds
        {
            get
            {
                return Logs.Select(l => new object[] { EventTestHelpers.BuildAndParse<ChatEvent>(l.LogText), l.SteamId });
            }
        }

        private static IEnumerable<ChatEventInfo> Logs
        {
            get
            {
                return new List<ChatEventInfo>
                {
                    new ChatEventInfo
                    {
                        LogText = "L 03/04/2013 - 20:19:01: \"Clipshow Hughot!<12><STEAM_0:1:9430005><Red>\" say \"hola\"",
                        Message = "hola", 
                        SteamId = "STEAM_0:1:9430005"
                    },
                    new ChatEventInfo
                    {
                        LogText = "L 03/04/2013 - 20:23:17: \"ranroll.esg<9><STEAM_0:1:10233891><Red>\" say \"It's a love story, baby just say yes <3\"",
                        Message = "It's a love story, baby just say yes <3", 
                        SteamId = "STEAM_0:1:10233891"
                    }
                };
            }
        }

        private class ChatEventInfo
        {
            public string LogText { get; set; }
            public  string Message { get; set; }

            public string SteamId { get; set; }
        }
    }
}
