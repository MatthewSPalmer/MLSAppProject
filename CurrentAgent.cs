using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLSApp
{
    internal class CurrentAgent  //  Class for holding the most recently selected agent and house
    {
        public int CurrentAgentId { get; set; }  //  Agent ID for selected agent
        public int CurrentHouseMLS { get; set; }  //  MLS number for selected house
        CurrentAgent() { }
        public static CurrentAgent currentAgent = new CurrentAgent();  //  Public instance for use across different forms 
    }
}
