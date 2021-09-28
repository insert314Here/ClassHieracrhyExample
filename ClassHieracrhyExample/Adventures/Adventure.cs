using ClassHieracrhyExample.Adventures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHieracrhyExample.Adventures
{
    public class Adventure
    {
        public string GUID;
        public string Title;
        public string Description;
        public int CompletionXPReward;
        public int CompletionGoldReward;
        public int MaxLevel;
        public int MinLevel;
        public List<Room> Rooms;


        public Adventure()
        {

        }
                
    }
}
