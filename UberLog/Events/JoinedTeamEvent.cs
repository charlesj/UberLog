// --------------------------------------------------------------------------------------------------------------------
// <copyright file="JoinedTeamEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The joined team event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The joined team event.
	/// </summary>
	public class JoinedTeamEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="JoinedTeamEvent"/> class.
		/// </summary>
		public JoinedTeamEvent()
		{
			this.Keystone = "joined team";
			this.Name = "JoinedTeam";
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