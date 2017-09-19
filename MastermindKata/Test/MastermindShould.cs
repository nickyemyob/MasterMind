using MastermindKata.Logic;
using NUnit.Framework;

namespace MastermindKata.Test
{
    [TestFixture]
    public class MastermindShould
    {
        private static readonly object[] OneMarkForTotalMatchingColour =
        {
            new object[] {1, new[]{"r","g","y","c"}, new[]{"r","w","w","w"} },
            new object[] {1, new[] { "r", "g", "y", "c" }, new[] { "w", "w", "r", "w" } }

        };

        private static readonly object[] TwoMarkForTotalMatchingColour =
        {
            new object[] {2, new[]{"r","g","y","c"}, new[]{"w","g","w","c"} },
            new object[] {2, new[]{"r","g","y","c"}, new[] { "w", "r", "w", "c" } },
            new object[] {3, new[] { "g", "g", "r", "c" }, new[] { "g", "r", "c", "y" } }
        };

        private static readonly object[] OneMarkForTotalMatchingPosition =
        {
            new object[] {1, new[]{"r","g","y","c"}, new[]{"r","w","w","w"} },
            new object[] {0, new[]{"r","g","y","c"}, new[] {"w","w","r","w"} }
        };


        private static readonly object[] TwoMarkForTotalMatchingPosition =
        {
            new object[] {2, new[]{"r","g","y","c"}, new[] {"r","g","w","r"} },
            new object[] {2, new[] { "w", "r", "c", "y" }, new[] {"r","r","c","w"}}
        };

        private static readonly object[] OneCorrectColourScenario =
        {
            new object[] {"b", "r,g,y,c", "r,w,w,w"},
            new object[] {"w", "r,g,y,c", "w,w,r,w"}
        };

        private static readonly object[] TwoCorrectColourScenario =
        {
            new object[] {"bb", "r,g,y,c", "w,g,w,c"},
            new object[] {"bw", "r,g,y,c", "w,r,w,c"},
            new object[] {"ww", "r,g,y,c", "g,w,c,w"}
        };

        private static readonly object[] ThreeCorrectColourScenario =
        {
            new object[] {"bbb", "r,g,y,c", "w,g,y,c"},
            new object[] {"bbw", "r,g,y,c", "w,r,y,c"},
            new object[] {"bww", "r,g,y,c", "w,r,g,c"},
            new object[] {"www", "r,g,y,c", "w,r,g,y"}
        };

        private static readonly object[] FourCorrectColourScenario =
        {
            new object[] {"bbbb", "r,g,y,c", "r,g,y,c"},
            new object[] {"bbww", "r,g,y,c", "r,g,c,y"},
            new object[] {"bwww", "r,g,y,c", "y,r,g,c"},
            new object[] {"wwww", "r,g,y,c", "c,r,g,y"}
        };

        [Test]
        [TestCaseSource(nameof(OneCorrectColourScenario))]
        [TestCaseSource(nameof(TwoCorrectColourScenario))]
        [TestCaseSource(nameof(ThreeCorrectColourScenario))]
        [TestCaseSource(nameof(FourCorrectColourScenario))]
        public void ReturnCorrectMark(string expectedMark, string code, string guess)
        {
            var mastermind = new Mastermind(new GuessValidator());
            var markResult = mastermind.ReturnMark(code, guess);
            Assert.AreEqual(expectedMark, markResult);
        }

        [Test]
        [TestCaseSource(nameof(OneMarkForTotalMatchingColour))]
        [TestCaseSource(nameof(TwoMarkForTotalMatchingColour))]
        public void ReturnTotalMatchingColour(int expected, string[] code, string[] guess)
        {
            var mastermind = new Mastermind(new GuessValidator());
            var totalMatchingColour = mastermind.ReturnWhiteMark(code, guess);
            Assert.AreEqual(expected, totalMatchingColour);
        }

        [Test]
        [TestCaseSource(nameof(OneMarkForTotalMatchingPosition))]
        [TestCaseSource(nameof(TwoMarkForTotalMatchingPosition))]
        public void ReturnTotalMatchingPosition(int expected, string[] code, string[] guess)
        {
            var mastermind = new Mastermind(new GuessValidator());
            var totalMatchingColour = mastermind.ReturnBlackMark(code, guess);
            Assert.AreEqual(expected, totalMatchingColour);
        }

        [Test]
        public void ReturnTrueIfPlayerHasWon()
        {
            var mastermind = new Mastermind(new GuessValidator());
            var actualCondition = mastermind.CheckWinCondition("bbbb");
            Assert.IsTrue(actualCondition);
        }

        [Test]
        public void ReturnFalseIfPlayerHasNotWon()
        {
            var mastermind = new Mastermind(new GuessValidator());
            var actualCondition = mastermind.CheckWinCondition("bbbw");
            Assert.IsFalse(actualCondition);
        }
    }
}
