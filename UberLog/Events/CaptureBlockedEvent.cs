// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CaptureBlockedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The capture blocked event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
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
		/// Gets or sets the player.
		/// </summary>
		public Player Player { get; set; }

		/// <summary>
		/// Gets or sets the point number.
		/// </summary>
		public int PointNumber { get; set; }

		/// <summary>
		/// Gets or sets the point name.
		/// </summary>
		public string PointName { get; set; }

		/// <summary>
		/// Gets or sets the position.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var matches = this.GetRegexMatches(); // returns 9 matches
			var playerString = matches[0].Value;
			var pointNumberString = matches[4].Value;
			var pointNameString = matches[6].Value;
			var positionstring = matches[8].Value;

		    this.Player = this.PlayerHelper(playerString);

			this.PointNumber = int.Parse(pointNumberString);
			this.PointName = pointNameString;
			this.Position = this.PositionHelper(positionstring);
		}
	}
}