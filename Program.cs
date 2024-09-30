//start main

Console.Clear();
string userInput = GetUserInput(); //prime

while (userInput != "4")
{
    PizzaRoute(userInput);
    userInput = GetUserInput(); //update
}
SayBye();

//end main

static void Pause()
{
    System.Console.WriteLine("\nPress any key to return to the menu...");
    Console.ReadKey();
    Console.Clear();
}

static void SayBye()
{
    System.Console.WriteLine("Thanks for window-shopping!");
}

static void DisplayMenu()
{
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.ForegroundColor = ConsoleColor.White;
    System.Console.WriteLine("Welcome to Crimson Crust!");
    System.Console.WriteLine("What kind of pizza slice would you like to see?");
    Console.ResetColor();
    System.Console.WriteLine("1. Plain Topping-less\n2. Cheese\n3. Pepperoni\n4. Exit\n");
}

static string GetUserInput()
{
    DisplayMenu();
    return Console.ReadLine();
}

static void PizzaRoute(string userInput)
{
    Console.Clear();
    switch(userInput)
        {
            case "1":
                PlainSlice();
                Pause();
                break;
            case "2":
                CheeseSlice();
                Pause();
                break;
            case "3":
                PepperoniSlice();
                Pause();
                break;
            case "4":
                SayBye();
                break;
            default:
                System.Console.WriteLine("Invalid selection, please try again.");
                PizzaRoute(userInput);
                break;
        }
}

#region Slices
static void PlainSlice()
{
    Random plainRandom = new Random();
    int randomRows = plainRandom.Next(8,13);

    for(int i = randomRows; i > 0; i--)
    {
        for(int j = i; j > 0; j--)
        {
            System.Console.Write("*");
        }
        System.Console.WriteLine();
    }
}

static void CheeseSlice()
{
    Random cheeseRandom = new Random();
    int randomRows = cheeseRandom.Next(8,13);

    for(int crust = randomRows + 1; crust > 0; crust --)
    {
        Console.Write("*");
    }
    System.Console.WriteLine();

    for(int i = randomRows; i > 1; i--)
    {
        System.Console.Write("*");
        for(int j = i-2; j > 0; j--)
        {
            System.Console.Write("#");
        }
        System.Console.Write("*");
        System.Console.WriteLine();
    }
    System.Console.WriteLine("*");
}

static void PepperoniSlice()
{
    Random pepRandom = new Random();
    int randomRows = pepRandom.Next(8,13);

    Random pepperoni = new Random();
    int pepperoniSlice = pepperoni.Next(5,10);


    for(int crust = randomRows + 1; crust > 0; crust --)
    {
        Console.Write("*");
    }
    System.Console.WriteLine();
    
    for(int i = randomRows; i > 1; i--)
    {
        System.Console.Write("*");
        for(int j = i-2; j > 0; j--)
        {
            Random corp = new Random();
            int corpSlice = corp.Next(1,11);  

            if(corpSlice == 7)
            {
                System.Console.Write("[]");
                j--;
            }
            else
            {
                Console.Write("#");
            }
        }
        System.Console.Write("*");
        System.Console.WriteLine();
    }
    Console.Write("*");
}
#endregion Slices