using ClassHieracrhyExample.Entities.Interfaces;
using ClassHieracrhyExample.Entities.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace ClassHieracrhyExample.Entities
{
    class CharacterService : ICharacterService
    {
        public Character LoadInitialCharacter()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}characters";
            var initialCharacter = new Character();

            if (File.Exists($"{basePath}\\conan.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("conan.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialCharacter = JsonConvert.DeserializeObject<Character>(fi.ReadToEnd());
                }
            }
            return initialCharacter;
        }
    }
}
