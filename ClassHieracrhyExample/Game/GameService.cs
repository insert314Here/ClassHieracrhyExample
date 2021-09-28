using ClassHieracrhyExample.Adventures;
using ClassHieracrhyExample.Adventures.Interfaces;
using ClassHieracrhyExample.Entities.Interfaces;
using ClassHieracrhyExample.Entities.Models;
using ClassHieracrhyExample.Game.Interfaces;
using System;

namespace ClassHieracrhyExample.Game
{
    public class GameService : IGameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;

        private Character character;

        //each class needs at least a default constructor
        public GameService(IAdventureService AdventureService, ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }


        public bool StartGame(Adventure adventure = null)
        {
            try
            {
                if (adventure == null)
                {
                    adventure = adventureService.GetInitialAdventure();
                }


                Console.Clear();
                Console.WriteLine();

                #region Aedventure Title Banner
                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }
                Console.WriteLine($"| {adventure.Title} |");

                for (int i = 0; i <= adventure.Title.Length + 3; i++)
                {
                    Console.Write("*");
                    if (i == adventure.Title.Length + 3)
                    {
                        Console.Write("\n");
                    }
                }
                #endregion

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"\n{adventure.Description.ToUpper()}");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;

                var charactersInRange = characterService.GetCharactersInRange(adventure.MinLevel, adventure.MaxLevel);
                if (charactersInRange.Count == 0)
                {
                    Console.WriteLine("You have no eligible characters in that range level for the adventure.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Watch out for the pig poop ;)");
                    var characterCount = 0;
                    foreach (var character in charactersInRange)
                    {
                        //the .properties only work because the character variable is ID'd in the foreach loop where CIR --> charService --> list from character.cs file is present

                        Console.WriteLine($"Adventurer #{characterCount} {character.Name}: Level - {character.Level} {character.Class}");
                        characterCount++;
                    }
                }
                character = characterService.LoadCharacter(charactersInRange[Convert.ToInt32(Console.ReadLine())].Name);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"something went wrong {ex.Message}");
            }
            return true;

        }
    }
}
