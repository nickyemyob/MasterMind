using System;
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
            Assert.Throws<ArgumentException>(() => guessValidator.CheckForComma("rgdf"));
            Assert.That(() => guessValidator.CheckForComma("rgdf"), Throws.TypeOf<ArgumentException>().With.Message.EqualTo(expectedErrorMessage));
        }

        [Test]
        public void ReturnErrorMessageWhenUserGuessContainsInvalidColour()
        {
            var guessValidator = new GuessValidator();
            const string expectedErrorMessage = "Guess should only contains r,g,y,c. Invalid colours are: d,f";
            Assert.Throws<ArgumentException>(() => guessValidator.CheckForInvalidColour("r,d,f,c"));
            Assert.That(() => guessValidator.CheckForInvalidColour("r,d,f,c"), Throws.TypeOf<ArgumentException>().With.Message.EqualTo(expectedErrorMessage));
        }
    }
}
