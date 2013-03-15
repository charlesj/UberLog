// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the ChatEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The chat event.
	/// </summary>
	public class ChatEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChatEvent"/> class.
		/// </summary>
		public ChatEvent()
		{
			this.Keystone = "say";
			this.Name = "Chat";
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public override string Name { get; protected set; }

		/// <summary>
		/// Gets or sets the keystone.
		/// </summary>
		public override string Keystone { get; protected set; }

	    /// <summary>
	    /// Gets or sets the player.
	    /// </summary>
	    public Player Player { get; set; }

	    /// <summary>
	    /// Gets or sets the message.
	    /// </summary>
	    public string Message { get; set; }

	    /// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
	    {
	        var matches = this.GetMatches();
	        var playerString = matches[0].Value;
	        var message = matches[2].Value;

	        this.Player = this.PlayerHelper(playerString);
	        this.Message = message;
	    }
	}
}