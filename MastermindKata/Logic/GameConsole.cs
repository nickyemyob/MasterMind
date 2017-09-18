

using System;

namespace MastermindKata.Logic
{
    public static class GameConsole
    {
        static void Main()
        {
            var mastermind = new Mastermind();
            var code = new Code();
            var guess = "";
            var response = "The mark was: ";
            
            while (guess != "stop")
            {
                Console.WriteLine("Welcome to Mastermind! Please insert your guess (eg: r,g,y,c)");
                guess = Console.ReadLine();
                if(guess == "stop") return;
                var mark = mastermind.ReturnMark(code.Generate(), guess);
                Console.WriteLine(response+ mark);
            }
            Console.ReadKey();
        }
    }
}
