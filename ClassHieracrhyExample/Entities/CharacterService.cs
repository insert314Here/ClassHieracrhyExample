using ClassHieracrhyExample.Entities.Interfaces;
using ClassHieracrhyExample.Entities.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ClassHieracrhyExample.Entities
{
    class CharacterService : ICharacterService
    {
        //first method in the interface-->need to implement all methods from interface
        public Character LoadCharacter(string name)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            //the character is created by instantiating the Character Class
            var character = new Character();

            //checking for exist of json file with character data
            if (File.Exists($"{basePath}\\{name}.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var characterJsonFile = directory.GetFiles($"{name}.json");

                using (StreamReader fi = File.OpenText(characterJsonFile[0].FullName))
                {
                    character = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }
            }
            else
            {
                throw new Exception("Character not found.");
            }
            return character;
        }
        //second method in the interface
        public List<Character> GetCharactersInRange(int minLevel = 0, int maxLevel = 20)
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            //return type in this method from the interface is a list
            var charactersInRange = new List<Character>();

            try
            {
                //this will scan the directory for all files ending in .json
                var directory = new DirectoryInfo(basePath);
                foreach (var file in directory.GetFiles($"*.json"))
                {
                    using (StreamReader fi = File.OpenText(file.FullName))
                    {
                        //as a json file is found, it becomes deserialized
                        var potentialCharacterInRange = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                        if (potentialCharacterInRange.IsAlive && (potentialCharacterInRange.Level >= minLevel && (potentialCharacterInRange.Level <= maxLevel)))
                        {
                            charactersInRange.Add(potentialCharacterInRange);
                        }
                    }
                        
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"something went wrong {ex.Message}");
            }
            return charactersInRange;

            
        }
    }
}
