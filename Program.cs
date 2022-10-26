
bool playAgain = true;
int index = 0;
bool userInput;
string userInput2;
bool gameLoop;
int Selection;
int cat1 = 1;
int cat2 = 2;
int cat3 = 3;
int cat4 = 4;


//---Arrays of Food Categories---//
string[] Category1 = {"Veggie Grill", "El Cantaro Vegan Restaurant","La Estrella", "Taqueria Don Chepe","Fiesta Taco", "Alberto's Cantina","Taqueria El Gallo", "Blue Agave Club","Chipotle Mexican Grill","Taqueria Los Pericos" };

string[] Category2 ={"Chili's Grill & Bar","American Waffle Diner","Cast Iron Trading Co.","Lumberjacks Restaurant","Denny's","The Creamery Restaurant","Bob's At The Marina","Jack in the Box","Market Tavern","Smitty's Wings & Things"};

string[] Category3 = {"New Fu Lim Restaurant", "Siamese Street Thai Restaurant","China Village Restaurant","Yen Du Restaurant", "Sun's Garden","New Yen Ching Restaurant","Tsing Tao Restaurant","Royal Siam", "Thai Me Up","Far East Restaurant"};

string[] Combined ={"Veggie Grill", "El Cantaro Vegan Restaurant","La Estrella", "Taqueria Don Chepe","Fiesta Taco", "Alberto's Cantina","Taqueria El Gallo", "Blue Agave Club","Chipotle Mexican Grill","Taqueria Los Pericos","Chili's Grill & Bar","American Waffle Diner","Cast Iron Trading Co.","Lumberjacks Restaurant","Denny's","The Creamery Restaurant","Bob's At The Marina","Jack in the Box","Market Tavern","Smitty's Wings & Things","New Fu Lim Restaurant", "Siamese Street Thai Restaurant","China Village Restaurant","Yen Du Restaurant", "Sun's Garden","New Yen Ching Restaurant","Tsing Tao Restaurant","Royal Siam", "Thai Me Up","Far East Restaurant"};


while(playAgain == true)
{
    do
    {

        Console.WriteLine("Welcome to Random Restaurant Picker");
        Console.WriteLine("We have 3 Food Categories and 1 Category to get any of the 3 Food Categories randomly.");
        Console.WriteLine("Type '1' for Mexican");
        Console.WriteLine("Type '2' for American");
        Console.WriteLine("Type '3' for Asian");
        Console.WriteLine("Type '4' for a wild card!");

        userInput = int.TryParse(Console.ReadLine(), out Selection);

        if(userInput == false)
        {
            Console.WriteLine("Pick a restaurant! The wife is hungry!");
        }
    }
    while(userInput == false);

    
    
    if(Selection == 1)
    {
        Console.WriteLine("Your randomly selected restaurant from category 1 is: "+ Category1[index]);
        RandomGen1();
    }

    if(Selection == 2)
    {
        Console.WriteLine("Your randomly selected restaurant from category 2 is: "+ Category2[index]);
        RandomGen2();
    }

    if(Selection == 3)
    {
        Console.WriteLine("Your randomly selected restaurant from category 3 is: "+ Category3[index]);
        RandomGen3();
    }

    if(Selection == 4)
    {
        Console.WriteLine("Your randomly selected restaurant from category 4 is: "+ Combined[index]);
        RandomGen4();
    }

    do
    {
        gameLoop = true;
        Console.WriteLine("Would you like to pick another restaurant? Y/N");
        userInput2 = Console.ReadLine().ToLower();

        if (userInput2 == "y")
        {
            playAgain = true;
        }

        else if (userInput2 == "n")
        {
            playAgain = false;
        }

    }
    

        while (gameLoop == false);
}

Console.WriteLine("Bye!");


//----Functions---//
void RandomGen1()
{
    Random rnd = new Random();
    index = rnd.Next(0, Category1.Length);
}

void RandomGen2()
{
    Random rnd = new Random();
    index = rnd.Next(0, Category2.Length);
}

void RandomGen3()
{
    Random rnd = new Random();
    index = rnd.Next(0, Category3.Length);
}

void RandomGen4()
{
    Random rnd = new Random();
    index = rnd.Next(0, Combined.Length);
}

