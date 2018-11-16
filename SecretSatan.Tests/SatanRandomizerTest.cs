using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretSatan.Tests
{
    [TestClass]
    public class SatanRandomizerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, true);
            Assert.AreNotEqual(true, false);
            CollectionAssert.AreEquivalent(new[] {1, 2, 3}, new[] {3, 1, 2});
        }

        static bool NotEqual(Dictionary<string, string> pairs)
        {
            foreach (var pair in pairs)
            {
                if (pair.Key == pair.Value)
                    return false;
            }

            return true;
        }

        static bool NotMatchingHunters(Dictionary<string, string> pairs)
        {
            foreach (var pair in pairs)
            {
                foreach (var pair2 in pairs)
                    if (pair.Key == pair2.Key)
                        return false;
            }

            return true;
        }

        static bool NotMatchingVictims(Dictionary<string, string> pairs)
        {
            foreach (var pair in pairs)
            {
                foreach (var pair2 in pairs)
                    if (pair.Value == pair2.Value)
                        return false;
            }

            return true;
        }

        static bool AllHaveVictims(Dictionary<string, string> pairs)
        {
            foreach (var pair in pairs)
            {
                if (string.IsNullOrEmpty(pair.Value.Trim()))
                    return false;
            }

            return true;
        }

        static bool AllHaveHunters(Dictionary<string, string> pairs)
        {
            foreach (var pair in pairs)
            {
                if (string.IsNullOrEmpty(pair.Key.Trim()))
                    return false;
            }

            return true;
        }

        static bool NotSpy(string[] people, Dictionary<string, string> pairs)
        {
            foreach (var pair in pairs)
                if (!people.Contains(pair.Value) || !people.Contains(pair.Key))
                    return false;
            return true;
        }

        static bool IsEqualCounts(string[] people, Dictionary<string, string> pairs)
        {
            return (int) Math.Ceiling((double) (people.Length / 2)) == (double) pairs.Count;
        }
    }
}