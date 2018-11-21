using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecretSatan.App;

namespace SecretSatan.Tests
{
    [TestClass]
    public class SatanRandomizerTest
    {
        static string[] testNames = { "Vasya", "Oleg", "Petya", "Alexandr", "Vadim", "Bill" };
        static Dictionary<string, string> pairs = SatanRandomizer.RandomizeSatanPairs(testNames);

        [TestMethod]
        public void NotEqual()
        {
            Assert.AreEqual(NotEqual(pairs), true);
        }

        [TestMethod]
        public void NotMatchingHunters()
        {
            Assert.AreEqual(NotMatchingHunters(pairs), true);
        }

        [TestMethod]
        public void NotMatchingVictims()
        {
            Assert.AreEqual(NotMatchingVictims(pairs), true);
        }

        [TestMethod]
        public void AllHaveVictims()
        {
            Assert.AreEqual(AllHaveVictims(pairs), true);
        }

        [TestMethod]
        public void AllHaveHunters()
        {
            Assert.AreEqual(AllHaveHunters(pairs), true);
        }

        [TestMethod]
        public void NotSpy()
        {
            Assert.AreEqual(NotSpy(testNames, pairs), true);
        }

        [TestMethod]
        public void IsEqualCounts()
        {
            Assert.AreEqual(IsEqualCounts(testNames, pairs), true);
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

        static bool NotMatchingHunters(Dictionary<string, string> pairs) //Changed
        {
            string[] hunters = pairs.Keys.ToArray();

            for (int i = 0; i < hunters.Length; i++)
                for (int j = 1 + i; j < hunters.Length; j++)
                    if (hunters[i] == hunters[j]) return false;

            return true;
        }

        static bool NotMatchingVictims(Dictionary<string, string> pairs) //Changed
        {
            string[] victims = pairs.Values.ToArray();

            for (int i = 0; i < victims.Length; i++)
                for (int j = 1 + i; j < victims.Length; j++)
                    if (victims[i] == victims[j]) return false;

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

        static bool IsEqualCounts(string[] people, Dictionary<string, string> pairs) //Changed
        {
            return people.Length == pairs.Count; 
        }
    }
}