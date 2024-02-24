using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceThrone
{
    internal class Operations
    {
        public Operations() { }

        public int getComplexity()
        {
            Console.WriteLine("Choose a complexity, 1-6: ");
            string input = Console.ReadLine();
            int complexityLevel = int.Parse(input);
            return complexityLevel;
        }

        public string getSeason()
        {
            Console.WriteLine("Choose the season you want to play: ");
            return Console.ReadLine();
        }
        public List<Character> makeComplexityList(List<Character> inputList)
        {
            List<Character> complexityList = new List<Character>();
            int complexityLevel = getComplexity();
            
            foreach (Character character in inputList)
            {
                if (character.Complexity == complexityLevel)
                {
                    complexityList.Add(character);
                }
            }
            
            return complexityList;
        }

        public List<Character> makeSeasonList(List<Character> inputList)
        {
            List<Character> seasonList = new List<Character>();
            string season = getSeason();

            foreach (Character character in inputList)
            {
                if (character.Season == season)
                {
                    seasonList.Add(character);
                }
            }

            return seasonList;
        }

        public string getListSelection()
        {
            Console.WriteLine("How would you like to filter your selection? \n1. Season\n2. Complexity ");
            return Console.ReadLine();
        }
    }
}

