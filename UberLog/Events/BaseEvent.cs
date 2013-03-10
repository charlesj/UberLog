// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseEvent.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the BaseEvent type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog.Events
{
	using System;
	using System.Diagnostics.CodeAnalysis;
	using System.Text.RegularExpressions;

	/// <summary>
	/// The base entry type.
	/// </summary>
	public abstract class BaseEvent : IEvent
	{
		/// <summary>
		/// The quote regex.
		/// </summary>
		[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:FieldNamesMustBeginWithLowerCaseLetter", Justification = "Reviewed. Suppression is OK here."),
		 SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed. Suppression is OK here.")]
		protected Regex QuoteRegex = new Regex("(?<=:?\")(.*?)(?=:?\")");

		/// <summary>
		/// The angle bracket regex.
		/// </summary>
		[SuppressMessage("StyleCop.CSharp.NamingRules", "SA1306:FieldNamesMustBeginWithLowerCaseLetter", Justification = "Reviewed. Suppression is OK here."),
		 SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Reviewed. Suppression is OK here.")]
		protected Regex AngleBracketRegex = new Regex("(?<=<)(.*?)(?=>)");

		/// <summary>
		/// The raw text.
		/// </summary>
		private string rawText;

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public abstract string Name { get; protected set; }

		/// <summary>
		/// Gets or sets the raw text.
		/// </summary>
		public string RawText
		{
			get
			{
				return this.rawText;
			}

			set
			{
				this.rawText = value;
				this.ParseDate();
			}
		}

		/// <summary>
		/// Gets or sets the keystone.
		/// </summary>
		public abstract string Keystone { get; protected set; }

		/// <summary>
		/// Gets or sets the event time.
		/// </summary>
		public DateTime EventTime { get; set; }

		/// <summary>
		/// The parse.
		/// </summary>
		public abstract void Parse();

		/// <summary>
		/// Figures out the date from the raw text
		/// </summary>
		private void ParseDate()
		{
			var text = this.rawText.Substring(0, 23);
			text = text.Replace("L", string.Empty).Replace("-", string.Empty);
			this.EventTime = DateTime.Parse(text);
		}
	}
}
