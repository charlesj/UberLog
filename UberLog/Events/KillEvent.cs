// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KillEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the KillEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The kill event.
	/// </summary>
	public class KillEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KillEvent"/> class.
		/// </summary>
		public KillEvent()
		{
			this.Keystone = "killed";
			this.Name = "Kill";
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
