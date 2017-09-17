using MastermindKata.Logic;
using NUnit.Framework;

namespace MastermindKata.Test
{
    [TestFixture]
    public class CodeShould
    {
        [Test]
        public void ReturnCorrectLengthCode()
        {
            var code = new Code();
            var randomCode = code.Generate();
            var defaultCodeLength = 4;
            Assert.AreEqual(defaultCodeLength, randomCode.Length);
        }
    }
}
