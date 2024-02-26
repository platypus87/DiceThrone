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

        
        public void printMenu()
        {
            Console.WriteLine("What would you like to do?\n" +
                "1. List all characters?\n" +
                "2. List characters by season?\n" +
                "3. List all characters by complexity?\n" +
                "4. Random character selecter?\n" +
                "5. Exit?");
        }

        public int getSelection()
        {
            string input = Console.ReadLine();
            int selection = int.Parse(input);
            //Need to add error handling here
            return selection;
        }
        public int getComplexity()
        {
            Console.WriteLine("Choose a complexity, 1-6: ");
            string input = Console.ReadLine();
            int complexityLevel = int.Parse(input);
            return complexityLevel;
        }

        public string getSeason()
        {
            Console.WriteLine("Which season would you like? ");
            return Console.ReadLine();
        }
        public List<Character> makeComplexityList(List<Character> Characters)
        {
            List<Character> complexityList = new List<Character>();
            int complexityLevel = getComplexity();
            
            foreach (Character character in Characters)
            {
                if (character.Complexity == complexityLevel)
                {
                    complexityList.Add(character);
                }
            }
            
            return complexityList;
        }

        public List<Character> makeSeasonList(List<Character> Characters)
        {
            List<Character> seasonList = new List<Character>();
            string season = getSeason();

            foreach (Character character in Characters)
            {
                if (character.Season == season)
                {
                    seasonList.Add(character);
                }
            }

            return seasonList;
        }


        public string getFilter()
        {
            Console.WriteLine("How would you like to filter your selection? \n1. Season\n2. Complexity ");
            return Console.ReadLine();
        }

        public void getRandomCharacter(List<Character> inputList)
        {
            string filter = getFilter();
            Character chosenCharacter;
            List<Character> characterList=new List<Character>();

            if (filter == "1")
            {
                characterList = makeSeasonList(inputList);
            }
            else if(filter == "2")
            {
                characterList = makeComplexityList(inputList);
            }
            
            Random random = new Random();
            chosenCharacter = characterList[random.Next(0,characterList.Count)];

            Console.WriteLine(chosenCharacter.ToString());

        }
    }
}

