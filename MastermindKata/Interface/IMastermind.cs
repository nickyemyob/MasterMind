namespace MastermindKata.Interface
{
    public interface IMastermind
    {
        bool CheckWinCondition(string mark);
        int ReturnBlackMark(string[] code, string[] guess);
        string ReturnMark(string code, string guess);
        int ReturnWhiteMark(string[] code, string[] guess);
    }
}