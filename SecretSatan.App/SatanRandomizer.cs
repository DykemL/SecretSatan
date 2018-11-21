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

            List<int> numbers = RandomizeNumbersWithoutRepetitions(0, names.Length - 1);

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

        public static List<int> RandomizeNumbersWithoutRepetitions(int startNum, int endNum)
        {
            Random rand = new Random();
            List<int> unrandomizedNums = new List<int> { };
            List<int> nums = new List<int> { };
            
            int rangeOfNums = endNum - startNum;
            for (int i = startNum; i <= rangeOfNums; i++)
                unrandomizedNums.Add(i);
            
            int num, numIndex;
            for (int i = 0; i <= rangeOfNums; i++)
            {
                numIndex = rand.Next(0, unrandomizedNums.Count);
                num = unrandomizedNums[numIndex];
                nums.Add(num);
                unrandomizedNums.RemoveAt(numIndex);
            }

            return nums;
        }
    }
}
