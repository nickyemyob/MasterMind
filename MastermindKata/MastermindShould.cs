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
            new object[] {0, "r,g,y,c", "w,w,r,w"}
        };


        [Test]
        public void ReturnBlackWhenCorrectColourAndPosition()
        {
            var mastermind = new Mastermind();
            var markResult = mastermind.ReturnMark("r,g,y,c", "r,w,w,w");
            Assert.AreEqual("b", markResult);
        }

        [Test]
        [TestCaseSource(nameof(OneMarkForTotalMatchingColour))]
        [TestCaseSource(nameof(TwoMarkForTotalMatchingColour))]
        public void ReturnTotalMatchingColour(int expected, string solution, string guess)
        {
            var mastermind = new Mastermind();
            var totalMatchingColour = mastermind.ReturnTotalMatchingColour(solution, guess);
            Assert.AreEqual(expected, totalMatchingColour);
        }

        [Test]
        [TestCaseSource(nameof(OneMarkForTotalMatchingPosition))]
        public void ReturnTotalMatchingPosition(int expected, string solution, string guess)
        {
            var mastermind = new Mastermind();
            var totalMatchingColour = mastermind.ReturnTotalMatchingPosition(solution, guess);
            Assert.AreEqual(expected, totalMatchingColour);
        }


    }
}
