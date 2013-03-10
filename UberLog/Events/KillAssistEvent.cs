// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KillAssistEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the KillAssistEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The kill assist event.
	/// </summary>
	public class KillAssistEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KillAssistEvent"/> class.
		/// </summary>
		public KillAssistEvent()
		{
			this.Keystone = "kill assist";
			this.Name = "KillAssist";
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