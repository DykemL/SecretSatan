using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretSatan.App
{
	public static class SatanRandomizer
	{
		public static Dictionary<string, string> GetSatanVictimPairs(string[] names)
		{
			var satanPairs = new Dictionary<string, string>();
			var victimsList = names.ToList();
			var satansList = names.ToList();
			
			var rand = new Random();
			var satansCount = 0;
			
			while (satansCount != names.Length)
			{
				var number = rand.Next(0, victimsList.Count);
				var newSatan = satansList[satansCount];
				var newVictim = victimsList[number];
				
				if (newSatan == newVictim) continue;
				
				satanPairs.Add(newSatan, newVictim);
				victimsList.Remove(newVictim);
				satansCount++;
			}

			return satanPairs;
		}
	}
}
