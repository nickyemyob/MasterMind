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
            var totalWhiteMark = 0;
            var guessList = guess.ToList();
            foreach (var color in code)
            {
                if (guessList.Contains(color))
                {
                    totalWhiteMark++;
                    guessList.RemoveAt(guessList.IndexOf(color));
                }
            }
            return totalWhiteMark;
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

        public bool CheckWinCondition(string mark)
        {
            const string winningMark = "bbbb";
            return mark == winningMark;
        }
    }
}
