// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuiltObjectEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the BuiltObjectEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	using System.Text.RegularExpressions;

	/// <summary>
	/// The built object event.
	/// </summary>
	public class BuiltObjectEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BuiltObjectEvent"/> class.
		/// </summary>
		public BuiltObjectEvent()
		{
			this.Keystone = "builtobject";
			this.Name = "BuiltObject";
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
		/// Gets or sets the position.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Gets or sets the object built.
		/// </summary>
		public GameObject ObjectBuilt { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			var quotationMatches = this.QuoteRegex.Matches(this.RawText); // there should be 7 matches player, triggered, builtobject, (object, obj_*, )(position, position
			var playerString = quotationMatches[0].Value;
			var objectString = quotationMatches[4].Value;
			var positionFlat = quotationMatches[6].Value;
			
			this.Player = new Player();
			this.Player.RawText = playerString;
			this.Player.Parse();

			var positionArray = positionFlat.Split(' ');
			this.Position = new Position();
			this.Position.X = int.Parse(positionArray[0]);
			this.Position.Y = int.Parse(positionArray[1]);
			this.Position.Z = int.Parse(positionArray[2]);

			this.ObjectBuilt = GameObject.Get(objectString);
		}
	}
}