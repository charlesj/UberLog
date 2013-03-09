// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SuicideEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the SuicideEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The suicide event.
	/// </summary>
	public class SuicideEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SuicideEvent"/> class.
		/// </summary>
		public SuicideEvent()
		{
			this.Keystone = "suicide";
			this.Name = "Suicide";
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