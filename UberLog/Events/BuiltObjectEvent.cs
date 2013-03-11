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
			var quotationMatches = this.GetRegexMatches(); // there should be 7 matches player, triggered, builtobject, (object, obj_*, )(position, position
			var playerString = quotationMatches[0].Value;
			var objectString = quotationMatches[4].Value;
			var positionString = quotationMatches[6].Value;
			
			this.Player = new Player { RawText = playerString };
			this.Player.Parse();

			this.Position = this.PositionHelper(positionString);

			this.ObjectBuilt = GameObject.Get(objectString);
		}
	}
}