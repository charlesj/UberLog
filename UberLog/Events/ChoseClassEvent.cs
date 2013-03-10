// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChoseClassEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The chose class event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The chose class event.
	/// </summary>
	public class ChoseClassEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ChoseClassEvent"/> class.
		/// </summary>
		public ChoseClassEvent()
		{
			this.Keystone = "changed role";
			this.Name = "ChoseClass";
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