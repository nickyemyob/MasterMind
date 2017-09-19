namespace MastermindKata.Interface
{
    public interface IGuessValidator
    {
        void CheckForComma(string guess);
        void CheckForInvalidColour(string guess);
    }
}