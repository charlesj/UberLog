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
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			throw new System.NotImplementedException();
		}
	}
}