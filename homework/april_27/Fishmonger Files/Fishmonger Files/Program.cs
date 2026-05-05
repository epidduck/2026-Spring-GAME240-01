
//special file
string special;
special = "";
string runSpecialLoop;
runSpecialLoop = "true";

while (runSpecialLoop == "true")
{
    try
    {
        Console.WriteLine("What is the file path for today's special?");
        string specialPath = Console.ReadLine();
        
        using (StreamReader specialFile = new StreamReader(specialPath))
        {
            special = specialFile.ReadLine();
        }
        Console.WriteLine(special);
        
        runSpecialLoop = "false";
    }
    catch (Exception noPathError)
    {
        Console.WriteLine("That file path does not exist. Try again.");
        special = "";
    }
}

//fishmonger log
string log;
log = "";
string runLogLoop;
runLogLoop = "true";

while (runLogLoop == "true")
{
    try
    {
        Console.WriteLine("What is the file path for the fishmonger's log?");
        string logPath = Console.ReadLine();
        
        using (StreamReader logFile = new StreamReader(logPath))
        {
            log = logFile.ReadToEnd();
        }
        Console.WriteLine(log);
        
        runLogLoop = "false";
    }
    catch (Exception noPathError)
    {
        Console.WriteLine("That file path does not exist. Try again.");
        log = "";
    }
}

//results file
Console.WriteLine("Where do you want to save the result?");
string resultPath = Console.ReadLine();

//creating results
//declaring special fish
string specialFish;
specialFish = "";
if (special.Contains("salmon"))
{
    specialFish = "salmon";
} else if (special.Contains("tuna"))
{
    specialFish = "tuna";
} else if (special.Contains("marlin"))
{
    specialFish = "marlin";
} else if (special.Contains("shrimp"))
{
    specialFish = "shrimp";
} else if (special.Contains("swordfish"))
{
    specialFish = "swordfish";
} else if (special.Contains("ahi"))
{
    specialFish = "ahi";
} else if (special.Contains("eel"))
{
    specialFish = "eel";
}
else
{
    Console.WriteLine("There does not appear to be a special today.");
}

//counting up total fish




