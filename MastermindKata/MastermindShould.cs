using NUnit.Framework;

namespace MastermindKata
{
    [TestFixture]
    public class MastermindShould
    {
        private static readonly object[] OneMarkForTotalMatchingColour =
        {
            new object[] {1, "r,g,y,c", "r,w,w,w" },
            new object[] {1, "r,g,y,c", "w,w,r,w" }

        };

        private static readonly object[] TwoMarkForTotalMatchingColour =
        {
            new object[] {2, "r,g,y,c", "w,g,w,c" },
            new object[] {2, "r,g,y,c", "w,r,w,c" }
        };

        private static readonly object[] OneMarkForTotalMatchingPosition =
        {
            new object[] {1, "r,g,y,c", "r,w,w,w" },
            new object[] {0, "r,g,y,c", "w,w,r,w"}
        };


        private static readonly object[] TwoMarkForTotalMatchingPosition =
        {
            new object[] {2, "r,g,y,c", "r,g,w,r" },
            new object[] {2, "w,r,c,y", "r,r,c,w" }
        };

        private static readonly object[] OneColorCorrectScenario =
        {
            new object[] {"b", "r,g,y,c", "r,w,w,w"},
            new object[] {"w", "r,g,y,c", "w,w,r,w"}
        };

        [Test]
        [TestCaseSource(nameof(OneColorCorrectScenario))]
        public void ReturnCorrectMark(string expectedMark, string code, string guess)
        {
            var mastermind = new Mastermind();
            var markResult = mastermind.ReturnMark(code, guess);
            Assert.AreEqual(expectedMark, markResult);
        }

        [Test]
        [TestCaseSource(nameof(OneMarkForTotalMatchingColour))]
        [TestCaseSource(nameof(TwoMarkForTotalMatchingColour))]
        public void ReturnTotalMatchingColour(int expected, string code, string guess)
        {
            var mastermind = new Mastermind();
            var totalMatchingColour = mastermind.ReturnTotalMatchingColour(code, guess);
            Assert.AreEqual(expected, totalMatchingColour);
        }

        [Test]
        [TestCaseSource(nameof(OneMarkForTotalMatchingPosition))]
        [TestCaseSource(nameof(TwoMarkForTotalMatchingPosition))]
        public void ReturnTotalMatchingPosition(int expected, string code, string guess)
        {
            var mastermind = new Mastermind();
            var totalMatchingColour = mastermind.ReturnTotalMatchingPosition(code, guess);
            Assert.AreEqual(expected, totalMatchingColour);
        }
    }
}
