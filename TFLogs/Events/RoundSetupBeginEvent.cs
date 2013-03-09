// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RoundSetupBeginEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The round setup begin event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The round setup begin event.
	/// </summary>
	public class RoundSetupBeginEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RoundSetupBeginEvent"/> class.
		/// </summary>
		public RoundSetupBeginEvent()
		{
			this.Keystone = "Round_Setup_Begin";
			this.Name = "RoundSetupBegin";
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