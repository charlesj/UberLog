namespace TFLogs
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class EntryType
	{
		private static EntryType unparsed = new EntryType() { Name = "Unparsed", Keystone = "Unparsed" };

		private static EntryType unknown = new EntryType() { Name = "Unknown", Keystone = "Unknown" };

		private static List<EntryType> all;

		public string Keystone { get; protected set; }

		public string Name { get; set; }

		public static List<EntryType> GetAll()
		{
			if (all == null)
			{
				var groups = new List<Tuple<string, string>>();
				groups.Add(new Tuple<string, string>("killed", "Kill"));
				groups.Add(new Tuple<string, string>("picked up item", "ItemPickup"));
				groups.Add(new Tuple<string, string>("damage", "Damage"));
				groups.Add(new Tuple<string, string>("suicide", "Suicide"));
				groups.Add(new Tuple<string, string>("healed", "Heal"));
				groups.Add(new Tuple<string, string>("say", "Chat"));
				groups.Add(new Tuple<string, string>("domination", "Domination"));
				groups.Add(new Tuple<string, string>("kill assist", "KillAssist"));
				groups.Add(new Tuple<string, string>("builtobject", "BuiltObject"));
				groups.Add(new Tuple<string, string>("revenge", "revenge"));
				groups.Add(new Tuple<string, string>("chargedeployed", "UberDeployed"));
				groups.Add(new Tuple<string, string>("medic_death", "MedicDeath"));
				groups.Add(new Tuple<string, string>("changed role", "ChoseClass"));
				groups.Add(new Tuple<string, string>("joined game", "JoinedGame"));
				groups.Add(new Tuple<string, string>("STEAM USERID validate", "SteamValidation"));
				groups.Add(new Tuple<string, string>("joined team", "JoinedTeam"));
				groups.Add(new Tuple<string, string>("player_extinguished", "ExtinguishedPlayer"));
				groups.Add(new Tuple<string, string>("Log file closed", "LogEnded"));
				groups.Add(new Tuple<string, string>("[META]", "Meta"));
				groups.Add(new Tuple<string, string>("connected", "Connected"));
				groups.Add(new Tuple<string, string>("entered the game", "EnteredGame"));
				groups.Add(new Tuple<string, string>("Round_Win", "RoundWin"));
				groups.Add(new Tuple<string, string>("Round_Length", "RoundLength"));
				groups.Add(new Tuple<string, string>("Round_Start", "RoundStart"));
				groups.Add(new Tuple<string, string>("Round_Setup_Begin", "RoundSetupBegin"));
				groups.Add(new Tuple<string, string>("Round_Setup_End", "RoundSetupEnd"));
				groups.Add(new Tuple<string, string>("captureblocked", "CaptureBlocked"));
				groups.Add(new Tuple<string, string>("Log file started", "LogStarted"));
				groups.Add(new Tuple<string, string>("changed name", "ChangedName"));
				groups.Add(new Tuple<string, string>("pointcaptured", "PointCaptured"));
				groups.Add(new Tuple<string, string>("final score", "FinalScore"));
				groups.Add(new Tuple<string, string>("current score", "CurrentScore"));
				groups.Add(new Tuple<string, string>("Game_Over", "GameOver"));

				var types = groups.Select(group => new EntryType() { Keystone = group.Item1, Name = group.Item2 }).ToList();
				types.Add(unknown);
				types.Add(unparsed);
				all = types;
			}

			return all;
		}

		public static EntryType Unparsed
		{
			get
			{
				return unparsed;
			}
		}

		public static EntryType Unknown
		{
			get
			{
				return unknown;
			}
		}
	}
}