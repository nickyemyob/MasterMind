using NUnit.Framework;

namespace MastermindKata
{
    [TestFixture]
    public class MastermindShould
    {
        private static readonly object[] OneMark =
        {
            new object[] {1, "r,g,y,c", "r,w,w,w" },
            new object[] {1, "r,g,y,c", "w,w,r,w" }
        };
        [Test]
        public void ReturnBlackWhenCorrectColourAndPosition()
        {
            var mastermind = new Mastermind();
            var markResult = mastermind.ReturnMark("r,g,y,c", "r,w,w,w");
            Assert.AreEqual("b", markResult);
        }

        [Test]
        [TestCaseSource(nameof(OneMark))]
        public void ReturnTotalMatchingColour(int expected, string solution, string guess)
        {
            var mastermind = new Mastermind();
            var totalMatchingColour = mastermind.ReturnTotalMatchingColour(solution, guess);
            Assert.AreEqual(expected, totalMatchingColour);
        }
    }
}
