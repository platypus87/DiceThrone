using diceThrone;

/* 
 * Creating the character list
 * Creating the characters
 * adding the characters to one list
 */

List<Character> allCharacters = new List<Character>();

//Season One Characters
Character Barbarian = new("Barbarian", "1", 1);
allCharacters.Add(Barbarian);

Character MoonElf = new("Moon Elf", "1", 2);
allCharacters.Add(MoonElf);

Character Pyromancer = new("Pyromancer", "1", 3);
allCharacters.Add(Pyromancer);

Character ShadowThief = new("Shadow Thief", "1", 5);
allCharacters.Add(ShadowThief);

Character Monk = new("Monk", "1", 4);
allCharacters.Add(Monk);

Character Paladin = new("Paladin", "1", 5);
allCharacters.Add(Paladin);

Character Ninja = new("Ninja", "1", 2);
allCharacters.Add(Ninja);

Character Treant = new("Treant", "1", 6);
allCharacters.Add(Treant);

//Season Two Characters
Character Gunslinger = new("Gunslinger", "2", 2);
allCharacters.Add(Gunslinger);

Character Samurai = new("Samurai", "2", 3);
allCharacters.Add(Samurai);

Character Tactician = new("Tactician", "2", 5);
allCharacters.Add(Tactician);

Character Huntress = new("Huntress", "2", 5);
allCharacters.Add(Huntress);

Character CursedPirate = new("Cursed Pirate", "2", 4);
allCharacters.Add(CursedPirate);

Character Artificer = new("Artificer", "2", 6);
allCharacters.Add(Artificer);

Character Seraph = new("Seraph", "2", 3);
allCharacters.Add(Seraph);

Character VampireLord = new("Vampire Lord", "2", 4);
allCharacters.Add(VampireLord);

//Marvel Character
Character Deadpool = new("Deadpool", "Marvel", 3);
//allCharacters.Add(Deadpool);

Character BlackPanther= new("Black Panther", "Marvel",2);
//allCharacters.Add(BlackPanther);

Character Wolverine= new("Wolverine", "Marvel",2);
//allCharacters.Add(Wolverine);

Character Storm = new("Storm", "Marvel", 4);
//allCharacters.Add(Storm);

Character Rogue= new("Rogue", "Marvel",3);
//allCharacters.Add(Rogue);

Character Psylocke= new("Psylocke", "Marvel", 3);
//allCharacters.Add(Psylocke);

Character JeanGrey= new("Jean Grey", "Marvel", 6);
//allCharacters.Add(JeanGrey);

Character Iceman= new("Iceman", "Marvel");
//allCharacters.Add(Iceman);

Character Gambit= new("Gambit", "Marvel", 6);
//allCharacters.Add(Gambit);

Character Cyclops= new("Cyclops", "Marvel", 4);
//allCharacters.Add(Cyclops);

Character MilesMorales= new("Miles Morales: Spider Man", "Marvel", 2);
//allCharacters.Add(MilesMorales);

Character ScarletWitch= new("Scarlet Witch", "Marvel", 4);
//allCharacters.Add(ScarletWitch);

Character Loki= new("Loki", "Marvel", 4);
//allCharacters.Add(Loki);

Character Thor= new("Thor", "Marvel", 3);
//allCharacters.Add(Thor);

Character CapMarvel= new("Captain Marvel", "Marvel", 2);
//allCharacters.Add(CapMarvel);

Character DocStrange= new("Doctor Strange", "Marvel", 5);
//allCharacters.Add(DocStrange);

Character BlackWidow= new("Black Widow", "Marvel", 4);
//allCharacters.Add(BlackWidow);

//Extra Characters
Character SantaClaus = new("Santa Claus", "Extra");
allCharacters.Add(SantaClaus);

Character Krampus = new("Krampus", "Extra", 4);
allCharacters.Add(Krampus);

/*
 * Program Functionality
 * Program flow:
 * Characters are created and added to the list
 * User needs to be asked how they want to filter
 * User's response dictates which function is ran
 */
Operations op = new();

List<Character> filteredList = new List<Character>();
string selectionNumber = op.getListSelection();

//Make a function for making a season selection list
if (selectionNumber == "1")
{
    filteredList = op.makeSeasonList(allCharacters);
}

//make a funtion for making a character complexity list
else if (selectionNumber == "2")
{
    filteredList = op.makeComplexityList(allCharacters);
}

foreach (Character character in filteredList)
{
    Console.WriteLine(character.ToString());
}

/**
 * makeList takes the input of the user as a string and the list of all the characters as parameters
 * the input AND the season of the characters are compared with toLower()
 * the characters that matche the filtering desires are added to the list that gets returned
 */