using ClassHieracrhyExample.Items.Models;
using System.Collections.Generic;

namespace ClassHieracrhyExample.Adventures.Models
{
    public class Chest
    {
        public bool Locked = false;
        public Trap Trap;
        public List<Item> Treasure;
        public int Gold;
    }
}
