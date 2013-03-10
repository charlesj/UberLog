// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UberDeployedEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the UberDeployedEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The uber deployed event.
	/// </summary>
	public class UberDeployedEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UberDeployedEvent"/> class.
		/// </summary>
		public UberDeployedEvent()
		{
			this.Keystone = "chargedeployed";
			this.Name = "ChargeDeployed";
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