using NUnit.Framework;

namespace MastermindKata
{
    [TestFixture]
    public class MastermindShould
    {
        [Test]
        public void ReturnOneCorrectColor()
        {
            var mastermind = new Mastermind();
            var markResult = mastermind.ReturnMark("r,g,y,c", "r,w,w,w");
            Assert.AreEqual("b", markResult);
        }
    }
}
