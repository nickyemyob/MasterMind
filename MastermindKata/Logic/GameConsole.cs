using System;
using MastermindKata.Interface;
using Microsoft.Practices.Unity;

namespace MastermindKata.Logic
{
    public static class GameConsole
    {
        static void Main()
        {
            RegisterDependencies();
            var mastermind = Container.Resolve<IMastermind>();
            var code = Container.Resolve<ICode>();
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

        private static UnityContainer Container { get; set; }

        static void RegisterDependencies()
        {
            Container = new UnityContainer();
            Container.RegisterType<IGuessValidator, GuessValidator>();
            Container.RegisterType<IGameConfigService, GameConfigService>();
            Container.RegisterType<IGameConfigSerialiser, GameConfigSerialiser>();
            Container.RegisterType<ICode, Code>();
            Container.RegisterType<IMastermind, Mastermind>();
        }
    }
}
