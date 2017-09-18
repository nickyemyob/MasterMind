using MastermindKata.Logic;
using NUnit.Framework;

namespace MastermindKata.Test
{
    [TestFixture]
    class GuessValidatorShould
    {
        [Test]
        public void ReturnErrorMessageWhenUserGuessDoesNotContainCommas()
        {
            var guessValidator = new GuessValidator();
            const string expectedErrorMessage = "Guess should contain commas between colours.";
            var actualErrorMessage = guessValidator.CheckForComma("rgdf");
            Assert.AreEqual(expectedErrorMessage, actualErrorMessage);
        } 
    }
}
