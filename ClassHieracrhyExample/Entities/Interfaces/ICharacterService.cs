using ClassHieracrhyExample.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHieracrhyExample.Entities.Interfaces
{
    public interface ICharacterService
    {
        public Character LoadCharacter(string name);

        //if nothing is sent into parameters, default parameters take affect
        public List<Character> GetCharactersInRange(int minLevel = 0, int maxLevel = 20);
    }
}
