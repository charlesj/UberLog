// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoundLengthEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The round length event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The round length event.
	/// </summary>
	public class RoundLengthEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RoundLengthEvent"/> class.
		/// </summary>
		public RoundLengthEvent()
		{
			this.Keystone = "Round_Length";
			this.Name = "RoundLength";
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