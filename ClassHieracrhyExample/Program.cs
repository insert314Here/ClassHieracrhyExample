using ClassHieracrhyExample.Game;
using System;

namespace ClassHieracrhyExample
{
    class Program
    {
        private static GameService gameService = new GameService();
        static void Main(string[] args)
        {
            MakeTitle();
            MakeMainMenu();
        }

        private static void MakeTitle()
        {
            Console.WriteLine("Welcome to ThunderDomeZ...2 men enter...1 man leaves\n\n");

        }

        static void MakeMainMenu()
        {
            MakeMenuOptions();
            bool inputValid = false;

            while (!inputValid)
            {
                switch (Console.ReadLine().ToUpper())
                {
                    case "S":
                        GameService.StartGame();
                        inputValid = true;
                        break;
                    case "C":
                        CreateCharacter();
                        inputValid = true;
                        break;
                    case "L":
                        LoadGame();
                        inputValid = true;
                        break;
                    default:
                        Console.WriteLine("You did not pick an available option");
                        MakeMenuOptions();
                        inputValid = false;
                        break;
                }
                                
            }

        }

        private static void MakeMenuOptions()
        {
            Console.WriteLine("\n(S)tart a new game");
            Console.WriteLine("(L)oad a game");
            Console.WriteLine("(C)reate a new character");
            
        }

        

        private static void CreateCharacter()
        {
            Console.WriteLine("you are creating a character");
        }

        private static void LoadGame()
        {
            Console.WriteLine("loading game");
        }
    }
}


