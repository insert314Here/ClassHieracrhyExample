using ClassHieracrhyExample.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHieracrhyExample.Adventures.Models
{
    public class Trap
    {
        public TrapType TrapType;
        public Die DamageDie = Die.D4;
        

    }

    public enum TrapType
    {
        Pit,Posion,Spike
    }
}
