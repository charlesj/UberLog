// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GameObject.cs" company="Josh Charles">
//   Licensed under the GPL.
// </copyright>
// <summary>
//   The game object.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace UberLog
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	/// The game object.
	/// </summary>
	public class GameObject
	{
		/// <summary>
		/// The game objects.
		/// </summary>
		private static readonly List<GameObject> GameObjects;

		/// <summary>
		/// Initializes static members of the <see cref="GameObject"/> class.
		/// </summary>
		static GameObject()
		{
			GameObjects = new List<GameObject>();
			GameObjects.Add(new GameObject { Name = "Sentry Gun", Code = "OBJ_SENTRYGUN" });
			GameObjects.Add(new GameObject { Name = "Sapper", Code = "OBJ_ATTACHMENT_SAPPER" });
			GameObjects.Add(new GameObject { Name = "Dispenser", Code = "OBJ_DISPENSER" });
			GameObjects.Add(new GameObject { Name = "Teleporter", Code = "OBJ_TELEPORTER" });
		}

		/// <summary>
		/// Prevents a default instance of the <see cref="GameObject"/> class from being created.
		/// </summary>
		private GameObject()
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
		/// The get.
		/// </summary>
		/// <param name="code">
		/// The code.
		/// </param>
		/// <returns>
		/// The <see cref="GameObject"/>.
		/// </returns>
		public static GameObject Get(string code)
		{
			if (GameObjects.All(go => go.Code != code))
			{
				return new GameObject() { Name = "Unknown", Code = code };
			}

			return GameObjects.Single(go => go.Code == code);
		}
	}
}