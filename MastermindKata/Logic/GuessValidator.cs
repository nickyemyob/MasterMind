namespace MastermindKata.Logic
{
    internal class GuessValidator
    {
        public string CheckForComma(string guess)
        {
            return !guess.Contains(",") ? "Guess should contain commas between colours." : string.Empty;
        }
    }
}
