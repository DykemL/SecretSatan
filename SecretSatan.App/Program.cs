using System;


namespace SecretSatan.App
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите список имён через запятую");
			string namesString;
			while (string.IsNullOrWhiteSpace(namesString = Console.ReadLine())) ;
			var names = namesString.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			var pairs = SatanRandomizer.GetSatanVictimPairs(names);

			foreach (var pair in pairs)
			{
				Console.WriteLine(pair.Key + " " + pair.Value);
			}

			Console.ReadKey();
		}
	}
}
