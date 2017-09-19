using MastermindKata.Logic;
using MastermindKata.Mock;
using NUnit.Framework;

namespace MastermindKata.Test
{
    [TestFixture]
    public class CodeShould
    {
        [Test]
        public void ReturnCorrectLengthCode()
        {
            var code = new Code(new GameConfigService(new MockGameConfigSerialiser()));
            var randomCode = code.Generate();
            var lengthOfCodeWithComma = 7;
            Assert.AreEqual(lengthOfCodeWithComma, randomCode.Length);
        }
    }
}
