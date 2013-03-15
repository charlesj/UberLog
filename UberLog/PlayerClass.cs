// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerClass.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   Defines the Classes type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog
{
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	/// The classes.
	/// </summary>
	public class PlayerClass
	{
		/// <summary>
		/// The classes.
		/// </summary>
		private static readonly List<PlayerClass> PlayerClasses;

		/// <summary>
		/// Initializes static members of the <see cref="PlayerClass"/> class.
		/// </summary>
		static PlayerClass()
		{
			PlayerClasses = new List<PlayerClass>
				            {
					            new PlayerClass { Name = "Demoman", Code = "demoman" },
					            new PlayerClass { Name = "Spy", Code = "spy" },
					            new PlayerClass { Name = "Scout", Code = "scout" },
					            new PlayerClass { Name = "Engineer", Code = "engineer" },
					            new PlayerClass { Name = "Medic", Code = "medic" },
					            new PlayerClass { Name = "Pyro", Code = "pyro" },
					            new PlayerClass { Name = "Sniper", Code = "sniper" },
					            new PlayerClass { Name = "Heavy Weapons", Code = "heavyweapons" },
					            new PlayerClass { Name = "Soldier", Code = "soldier" }
				            };
		}

		/// <summary>
		/// Prevents a default instance of the <see cref="PlayerClass"/> class from being created. 
		/// </summary>
		private PlayerClass()
		{
		}

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		public string Code { get; set; }

		/// <summary>
		/// The get player class for code.
		/// </summary>
		/// <param name="code">
		/// The code.
		/// </param>
		/// <returns>
		/// The <see cref="PlayerClass"/>.
		/// </returns>
		public static PlayerClass GetPlayerClassForCode(string code)
		{
			if (PlayerClasses.All(pc => pc.Code != code))
			{
				return new PlayerClass { Name = "Unknown", Code = code };
			}

			return PlayerClasses.Single(pc => pc.Code == code);
		}
	}
}
