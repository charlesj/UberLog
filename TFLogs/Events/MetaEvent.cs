// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MetaEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The meta event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The meta event.
	/// </summary>
	public class MetaEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MetaEvent"/> class.
		/// </summary>
		public MetaEvent()
		{
			this.Keystone = "[META]";
			this.Name = "Meta";
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