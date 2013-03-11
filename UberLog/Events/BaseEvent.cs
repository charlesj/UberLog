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
		/// The get regex matches.
		/// </summary>
		/// <returns>
		/// The <see cref="MatchCollection"/>.
		/// </returns>
		protected MatchCollection GetRegexMatches()
		{
			return this.QuoteRegex.Matches(this.rawText);
		}

		/// <summary>
		/// The position helper.
		/// </summary>
		/// <param name="positionString">
		/// The position string.
		/// </param>
		/// <returns>
		/// The <see cref="Position"/>.
		/// </returns>
		protected Position PositionHelper(string positionString)
		{
			var positionArray = positionString.Split(' ');
			var position = new Position();
			position.X = int.Parse(positionArray[0]);
			position.Y = int.Parse(positionArray[1]);
			position.Z = int.Parse(positionArray[2]);
			return position;
		}

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
