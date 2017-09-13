using System.Linq;

namespace MastermindKata
{
    public class Mastermind
    {

        public string ReturnMark(string code, string guess)
        {
            GetCodeAndGuessArray(code, guess, out string[] codeArray, out string[] guessArray);
            var totalMatchingPosition = ReturnTotalMatchingPosition(codeArray, guessArray);
            var totalMatchingColour = ReturnTotalMatchingColour(codeArray, guessArray);
            return new string('b', totalMatchingPosition) + new string('w', totalMatchingColour - totalMatchingPosition); 
        }

        public int ReturnTotalMatchingColour(string[] code, string[] guess)
        {
            return code.Intersect(guess).Count();
        }

        public int ReturnTotalMatchingPosition(string[] code, string[] guess)
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
