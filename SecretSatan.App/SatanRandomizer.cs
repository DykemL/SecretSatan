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
            Dictionary<string, string> pairs = new Dictionary<string, string> { }; 

            List<int> numbers = RandomizeNumbersWithExceptions(0, names.Length - 1);

            int countOfPairs = names.Length;
            for(int i = 0; i < countOfPairs; i++)
            {
                if (i == countOfPairs - 1)
                    pairs.Add(names[numbers[i]], names[numbers[0]]);
                else
                    pairs.Add(names[numbers[i]], names[numbers[i+1]]);
            }
            return pairs;
        }

        public static List<int> RandomizeNumbersWithExceptions(int startNum, int endNum)
        {
            Random rand = new Random();
            List<int> UnrandomizedNums = new List<int> { };
            List<int> Nums = new List<int> { };
            
            int rangeOfNums = endNum - startNum;
            for (int i = startNum; i <= rangeOfNums; i++)
                UnrandomizedNums.Add(i);
            
            int num, numIndex;
            for (int i = 0; i <= rangeOfNums; i++)
            {
                numIndex = rand.Next(0, UnrandomizedNums.Count);
                num = UnrandomizedNums[numIndex];
                Nums.Add(num);
                UnrandomizedNums.RemoveAt(numIndex);
            }

            return Nums;
        }
    }
}
