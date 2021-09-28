using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHieracrhyExample.Adventures.Interfaces
{
    public interface IAdventureService
    {
        //calls on the Adventure class
      
        Adventure GetInitialAdventure();
    }
}
