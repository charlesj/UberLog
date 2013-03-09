// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConnectedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The connected event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The connected event.
	/// </summary>
	public class ConnectedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConnectedEvent"/> class.
		/// </summary>
		public ConnectedEvent()
		{
			this.Keystone = "connected";
			this.Name = "Connected";
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