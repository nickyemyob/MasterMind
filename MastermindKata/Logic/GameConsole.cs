using System;

namespace MastermindKata.Logic
{
    public static class GameConsole
    {
        static void Main()
        {
            var mastermind = new Mastermind(new GuessValidator());
            var code = new Code();
            var guess = "";
            const string response = "The mark was: ";
            var randomCode = code.Generate();
            Console.WriteLine("Welcome to Mastermind! ");
            while (guess != "stop")
            {
                Console.WriteLine("Please insert your guess (eg: r,g,y,c)");
                guess = Console.ReadLine();
                if(guess == "stop") return;
                try
                {
                    var mark = mastermind.ReturnMark(randomCode, guess);
                    if(mastermind.CheckWinCondition(mark))
                    {
                        Console.WriteLine("You have won the game!");
                        Console.ReadKey();
                        return;
                    }
                    Console.WriteLine(response + mark + Environment.NewLine);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + Environment.NewLine);
                }
            }
            Console.ReadKey();
        }
    }
}
