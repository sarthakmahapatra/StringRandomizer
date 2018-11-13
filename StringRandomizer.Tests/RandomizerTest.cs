using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringRandomizer.Options;
using StringRandomizer.Stores;

namespace StringRandomizer.Tests
{
    [TestClass]
    [TestCategory("Randomizer")]
    public class RandomizerTest
    {
        [TestMethod]
        public void GivenRandomize_WhenNoOptions_ThenStringWithLenght10WithNumAndUpper()
        {
            //a
            var randomizer = new Randomizer();
            Regex rgx = new Regex(@"^[A-Z0-9]{10}$");

            //a
            var result = randomizer.Next();

            //a
            Assert.IsTrue(rgx.IsMatch(result));
            Assert.AreEqual(10, result.Length);

        }

        [TestMethod]
        public void GivenRandomize_WhenDefaultRandomizerOptionsLength6_ThenStringWithLenght6WithNumAndUpper()
        {
            //a
            var randomizer = new Randomizer(6, new DefaultRandomizerOptions());
            Regex rgx = new Regex(@"^[A-Z0-9]{6}$");

            //a
            var result = randomizer.Next();

            //a
            Assert.IsTrue(rgx.IsMatch(result));
            Assert.AreEqual(6, result.Length);
        }

        [TestMethod]
        public void GivenRandomize_WhenDefaultRandomizerOptionsLength6AndLowerTrue_ThenStringWithLenght6WithNumAndUpperAndLower()
        {
            //a
            var randomizer = new Randomizer(6, new DefaultRandomizerOptions(hasLowerAlphabets:true));
            Regex rgx = new Regex(@"^[A-Za-z0-9]{6}$");

            //a
            var result = randomizer.Next();

            //a
            Assert.IsTrue(rgx.IsMatch(result));
            Assert.AreEqual(6, result.Length);
        }

        [TestMethod]
        public void GivenRandomize_WhenDefaultStoreAndLength6_ThenStringWithLenght6WithNumAndUpper()
        {
            //a
            var store = new DefaultRandomizerStore();
            var randomizer = new Randomizer(6, store: store);
            Regex rgx = new Regex(@"^[A-Za-z0-9]{6}$");

            //a
            var result = randomizer.Next();

            //a
            Assert.IsTrue(rgx.IsMatch(result));
            Assert.AreEqual(6, result.Length);
            Assert.IsFalse(store.TryAdd(result));
        }
    }
}
