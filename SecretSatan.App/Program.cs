using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Dictionary<string, string> pairs = SatanRandomizer.RandomizeSatanPairs(names);
            foreach(var pair in pairs)
            {
                Console.WriteLine(pair.Key + " => " + pair.Value);
            }
            Console.ReadKey();
		}
    }
}
