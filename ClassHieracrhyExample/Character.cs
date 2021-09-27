using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHieracrhyExample
{
    abstract class Character
    {
        protected string Name { get; set; }

        protected int Health { get; set; }

        protected int Dexterity { get; set; }

        protected int Luck { get; set; }

        protected int Strength { get; set; }

        protected int Intellect { get; set; }


        public Character(string name, int health, int dex, int luck, int str, int intell)
        {
            Name = name;
            Health = health;
            Dexterity = dex;
            Luck = luck;
            Strength = str;
            Intellect = intell;

        }
    }



}
