// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnparsedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the UnparsedEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The unparsed entry type.
	/// </summary>
	public class UnparsedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UnparsedEvent"/> class.
		/// </summary>
		public UnparsedEvent()
		{
			this.Name = "Unparsed";
			this.Keystone = this.GetType().ToString();
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
			// nothing to do
		}
	}
}
