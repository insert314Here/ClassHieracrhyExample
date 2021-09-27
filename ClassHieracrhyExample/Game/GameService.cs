using ClassHieracrhyExample.Adventures;
using Newtonsoft.Json;
using System;
using System.IO;

namespace ClassHieracrhyExample.Game
{
    public class GameService
    {

        public static void StartGame()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}adventures";
            var initialAdventure = new Adventure();

            if (File.Exists($"{basePath}\\initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("initial.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
                }

                Console.WriteLine($"Adventure : {initialAdventure.Title}");
                Console.WriteLine($"Adventure : {initialAdventure.Description}");
            }
            Console.WriteLine("you started a new game");
        }
    }
}
