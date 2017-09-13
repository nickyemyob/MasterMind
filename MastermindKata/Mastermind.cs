using System.Linq;

namespace MastermindKata
{
    public class Mastermind
    {
        public string ReturnMark(string code, string guess)
        {
            return "b";
        }

        public int ReturnTotalMatchingColour(string code, string guess)
        {
            var solutionArray = code.Split(',');
            var guessArray = guess.Split(',');

            return solutionArray.Intersect(guessArray).Count();
        }

        public int ReturnTotalMatchingPosition(string code, string guess)
        {
            var solutionArray = code.Split(',');
            var guessArray = guess.Split(',');

            return solutionArray.Where((t, i) => t == guessArray[i]).Count();
        }
    }
}
