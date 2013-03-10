// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MedicDeathEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The medic death event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The medic death event.
	/// </summary>
	public class MedicDeathEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MedicDeathEvent"/> class.
		/// </summary>
		public MedicDeathEvent()
		{
			this.Keystone = "medic_death";
			this.Name = "MedicDeath";
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