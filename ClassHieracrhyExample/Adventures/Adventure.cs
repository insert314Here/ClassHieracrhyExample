using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHieracrhyExample.Adventures
{
    public class Adventure
    {
        public string GUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CompletionXPReward { get; set; }
        public int CompletionGoldReward { get; set; }
        public int MaxLevel { get; set; }
        public int MinLevel { get; set; }

        public Adventure()
        {

        }
        
        /// <summary>
        /// This class does this and that
        /// </summary>
        public void myMethod()
        {

        }
    }
}
