// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JoinedGameEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The joined game event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The joined game event.
	/// </summary>
	public class JoinedGameEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JoinedGameEvent"/> class.
		/// </summary>
		public JoinedGameEvent()
		{
			this.Keystone = "joined game";
			this.Name = "JoinedGame";
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