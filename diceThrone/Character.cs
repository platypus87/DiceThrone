using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceThrone
{
    internal class Character
    {
        public string Name;
        public string Season;
        public int Complexity;

        public Character(string name, string season = "", int complexity = 0)
        {
            this.Name=name;
            this.Season = season;
            this.Complexity=complexity;
        }

        public override string ToString()
        {
            return $"{Name} - Season: {Season} - Complexity: {Complexity}"; ;
        }
    }
}
