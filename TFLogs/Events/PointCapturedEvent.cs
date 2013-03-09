// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PointCapturedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The point captured event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The point captured event.
	/// </summary>
	public class PointCapturedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PointCapturedEvent"/> class.
		/// </summary>
		public PointCapturedEvent()
		{
			this.Keystone = "pointcaptured";
			this.Name = "PointCaptured";
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