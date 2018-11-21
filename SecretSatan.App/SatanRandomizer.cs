using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSatan.App
{
    public static class SatanRandomizer
    {
        public static Dictionary<string, string> RandomizeSatanPairs(string[] names) 
        {
            var pairs = new Dictionary<string, string>();
            var numbers = RandomizeNumbersWithoutRepetitions(0, names.Length - 1);

            var pairsCount = names.Length;
            for (var i = 0; i < pairsCount; i++)
            {
                var secondNameIndex = i == pairsCount - 1 ? 0 : i + 1;
                pairs.Add(names[numbers[i]], names[numbers[secondNameIndex]]);
            }
            
            return pairs;
        }

        public static List<int> RandomizeNumbersWithoutRepetitions(int startNum, int endNum)
        {
            var rand = new Random();
            var unrandomizedNums = new List<int>();
            var nums = new List<int>();
            
            var maxOfNums = endNum - startNum;
            for (var i = startNum; i <= maxOfNums; i++)
                unrandomizedNums.Add(i);
            
            for (var i = 0; i <= maxOfNums; i++)
            {
                var numIndex = rand.Next(0, unrandomizedNums.Count);
                var num = unrandomizedNums[numIndex];
                nums.Add(num);
                unrandomizedNums.RemoveAt(numIndex);
            }

            return nums;
        }
    }
}
