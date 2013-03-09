// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemPickupEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the ItemPickupEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TFLogs.Events
{
	/// <summary>
	/// The item pickup event.
	/// </summary>
	public class ItemPickupEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ItemPickupEvent"/> class.
		/// </summary>
		public ItemPickupEvent()
		{
			this.Keystone = "picked up item";
			this.Name = "ItemPickup";
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