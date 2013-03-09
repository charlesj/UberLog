// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DamageEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the DamageEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The damage event.
	/// </summary>
	public class DamageEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="DamageEvent"/> class.
		/// </summary>
		public DamageEvent()
		{
			this.Keystone = "damage";
			this.Name = "Damage";
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