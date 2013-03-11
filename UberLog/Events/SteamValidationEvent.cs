// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SteamValidationEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The steam validation event.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	/// <summary>
	/// The steam validation event.
	/// </summary>
	public class SteamValidationEvent : BaseEvent
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SteamValidationEvent"/> class.
		/// </summary>
		public SteamValidationEvent()
		{
			this.Keystone = "STEAM USERID validate";
			this.Name = "SteamValidation";
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