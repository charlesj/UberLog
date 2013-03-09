// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BuiltObjectEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the BuiltObjectEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
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
		/// The parse.
		/// </summary>
		public override void Parse()
		{
			throw new System.NotImplementedException();
		}
	}
}