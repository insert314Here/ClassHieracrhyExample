using ClassHieracrhyExample.Adventures;
using ClassHieracrhyExample.Game;
using System;
using ClassHieracrhyExample.Adventures.Interfaces;
using ClassHieracrhyExample.Entities;

namespace ClassHieracrhyExample
{
    class Program
    {
        private static AdventureService adventureService = new AdventureService();
        private static CharacterService characterService = new CharacterService();
        private static GameService gameService = new GameService(adventureService, characterService);

        static void Main(string[] args)
        {
            MakeTitle();
            MakeMainMenu();
        }

        private static void MakeTitle()
        {
            Console.WriteLine("This is the game");

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
                        gameService.StartGame();
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


