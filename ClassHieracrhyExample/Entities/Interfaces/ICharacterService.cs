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
        public Character LoadInitialCharacter();
    }
}
