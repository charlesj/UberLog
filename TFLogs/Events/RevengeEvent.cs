// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RevengeEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the RevengeEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The revenge event.
	/// </summary>
	public class RevengeEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RevengeEvent"/> class.
		/// </summary>
		public RevengeEvent()
		{
			this.Keystone = "revenge";
			this.Name = "Revenge";
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
		/// <exception cref="NotImplementedException">
		/// </exception>
		public override void Parse()
		{
			throw new System.NotImplementedException();
		}
	}
}