// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoundWinEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The round win event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The round win event.
	/// </summary>
	public class RoundWinEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RoundWinEvent"/> class.
		/// </summary>
		public RoundWinEvent()
		{
			this.Keystone = "Round_Win";
			this.Name = "RoundWin";
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