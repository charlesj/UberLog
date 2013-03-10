// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HealEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The heal event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The heal event.
	/// </summary>
	public class HealEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HealEvent"/> class.
		/// </summary>
		public HealEvent()
		{
			this.Keystone = "healed";
			this.Name = "Heal";
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