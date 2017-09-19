using System.Linq;
using MastermindKata.Interface;

namespace MastermindKata.Logic
{
    public class Mastermind
    {
        private IGuessValidator GuessValidator { get; set; }

        public Mastermind(IGuessValidator guessValidator)
        {
            GuessValidator = guessValidator;
        }

        public string ReturnMark(string code, string guess)
        {
            GuessValidator.CheckForComma(guess);
            GuessValidator.CheckForInvalidColour(guess);
            GetCodeAndGuessArray(code, guess, out string[] codeArray, out string[] guessArray);
            var blackMark = ReturnBlackMark(codeArray, guessArray);
            var whiteMark = ReturnWhiteMark(codeArray, guessArray);
            return new string('b', blackMark) + new string('w', whiteMark - blackMark); 
        }

        public int ReturnWhiteMark(string[] code, string[] guess)
        {
            return code.Intersect(guess).Count();
        }

        public int ReturnBlackMark(string[] code, string[] guess)
        {
            return code.Where((t, i) => t == guess[i]).Count();
        }

        private static void GetCodeAndGuessArray(string code, string guess, out string[] codeArray, out string[] guessArray)
        {
            codeArray = code.Split(',');
            guessArray = guess.Split(',');
        }
    }
}
