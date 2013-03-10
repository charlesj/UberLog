// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChangedNameEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The changed name event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The changed name event.
	/// </summary>
	public class ChangedNameEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChangedNameEvent"/> class.
		/// </summary>
		public ChangedNameEvent()
		{
			this.Keystone = "changed name";
			this.Name = "ChangedName";
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