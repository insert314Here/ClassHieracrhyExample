using ClassHieracrhyExample.Adventures;
using ClassHieracrhyExample.Adventures.Interfaces;
using ClassHieracrhyExample.Entities.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;

namespace ClassHieracrhyExample.Game
{
    public class GameService
    {
        private IAdventureService adventureService;
        private ICharacterService characterService;

        //each class needs at least a default constructor
        public GameService(IAdventureService AdventureService,ICharacterService CharacterService)
        {
            adventureService = AdventureService;
            characterService = CharacterService;
        }

        
        public void StartGame()
        {
            var initialAdventure = adventureService.GetInitialAdventure();
            var initialCharacter = characterService.LoadInitialCharacter();

            Console.WriteLine($"Adventure : {initialAdventure.Title}");
            Console.WriteLine($"Description : {initialAdventure.Description}");

            Console.WriteLine($"Character Name : {initialCharacter.Name}");
            Console.WriteLine($"Level : {initialCharacter.Level}");
        }
    }
}
