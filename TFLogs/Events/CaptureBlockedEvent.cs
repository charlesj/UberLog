// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaptureBlockedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The capture blocked event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The capture blocked event.
	/// </summary>
	public class CaptureBlockedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CaptureBlockedEvent"/> class.
		/// </summary>
		public CaptureBlockedEvent()
		{
			this.Keystone = "captureblocked";
			this.Name = "CaptureBlocked";
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