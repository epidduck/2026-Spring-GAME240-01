
Console.WriteLine("Welcome to this old victorian home! You've heard " +
                  "rumors that it used to be owned by a very wealthy " +
                  "man who died mysteriously. It's been abandoned " +
                  "ever since. Well anyway, it's time to explore! " +
                  "Use the Move command to move, the Take command " +
                  "to take objects you find and the Use command to " +
                  "use them.");

string userCommand;
Room currentRoom = Room.Outside;
bool hasCopperKey = false;
bool hasSuspiciousBook = false;
bool suspiciousBookOpen = false;
bool drawerUnlocked = false;
bool hasScrewdriver = false;
bool floorboardUnlocked = false;
bool hasGoldKey = false;
bool basementClosetUnlocked = false;

switch (currentRoom)
{
    case Room.Outside:
        Console.WriteLine("OUTSIDE");
        Console.WriteLine("You are outside of an old victorian home. North of you stands a locked door with a" +
                          " silver keyhole, a dead potted plant and a welcome mat. You can take a silver key from" +
                          " the potted plant.");
        bool isOutside = true;
        bool hasSilverKey = false;
        bool doorUnlocked = false;
        while (isOutside == true)
        {
            while (hasSilverKey == false)
            {
                userCommand = Console.ReadLine().ToLower();
                if (userCommand == "move south")
                {
                    Console.WriteLine("Your path is blocked by a gate.");
                } else if (userCommand == "move east")
                {
                    Console.WriteLine("Your path is blocked by a fence.");
                } else if (userCommand == "move west")
                {
                    Console.WriteLine("Your path is blocked by a fence.");
                } else if (userCommand == "move north")
                {
                    Console.WriteLine("The door is locked.");
                } else if (userCommand == "take silver key")
                {
                    Console.WriteLine("You've taken the silver key.");
                    hasSilverKey = true;
                } else
                {
                    Console.WriteLine("I'm not sure what you mean.");
                }
            }
            hasSilverKey = true;
            while (doorUnlocked == false)
            {
                userCommand = Console.ReadLine().ToLower();
                if (userCommand == "move south")
                {
                    Console.WriteLine("Your path is blocked by a gate.");
                } else if (userCommand == "move east")
                {
                    Console.WriteLine("Your path is blocked by a fence.");
                } else if (userCommand == "move west")
                {
                    Console.WriteLine("Your path is blocked by a fence.");
                } else if (userCommand == "move north")
                {
                    Console.WriteLine("The door is locked.");
                } else if (userCommand == "use silver key")
                {
                    Console.WriteLine("You've unlocked the door.");
                    doorUnlocked = true;
                } else
                {
                    Console.WriteLine("I'm not sure what you mean.");
                }
            }
            doorUnlocked = true;
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("Your path is blocked by a gate.");
            } else if (userCommand == "move east")
            {
                Console.WriteLine("Your path is blocked by a fence.");
            } else if (userCommand == "move west")
            {
                Console.WriteLine("Your path is blocked by a fence.");
            } else if (userCommand == "move north")
            {
                goto case Room.SouthFoyer;
                isOutside = false;
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        } doorUnlocked = true;
        break;
    case Room.SouthFoyer:
        Console.WriteLine("FOYER SOUTH END");
        Console.WriteLine("You stand in the south end of the foyer. To the north is the north end of the foyer. There" +
                          " are doors to the west, south and east of you.");
        bool isInSouthFoyer = true;
        while (isInSouthFoyer == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                goto case Room.Outside;
            } else if (userCommand == "move east")
            {
                goto case Room.Study;
            } else if (userCommand == "move west")
            {
                goto case Room.Kitchen;
            } else if (userCommand == "move north")
            {
                goto case Room.NorthFoyer;
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.NorthFoyer:
        Console.WriteLine("FOYER NORTH END");
        Console.WriteLine("You stand in the north end of the foyer. To the south of you is the south end of the" +
                          " foyer. There are doors to the east and west of you. The are a flights of stairs north of" +
                          " you that go upstairs and downstairs.");
        bool isInNorthFoyer = true;
        while (isInNorthFoyer == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                goto case Room.SouthFoyer;
            } else if (userCommand == "move east")
            {
                goto case Room.GuestRoom;
            } else if (userCommand == "move west")
            {
                goto case Room.FirstBathroom;
            } else if (userCommand == "move north")
            {
                Console.WriteLine("Please specify \"move upstairs\" or" +
                                  " \"move downstairs\"");
            } else if (userCommand == "move upstairs")
            {
                goto case Room.SecondLanding;
            } else if (userCommand == "move downstairs")
            {
                goto case Room.BasementLanding;
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.Kitchen:
        Console.WriteLine("KITCHEN");
        Console.WriteLine("You stand in the kitchen. There is a door to the east.");
        bool isInKitchen = true;
        while (isInKitchen == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                goto case Room.SouthFoyer;
            } else if (userCommand == "move west")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move north")
            {
                Console.WriteLine("You can't go that way.");
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.Study:
        Console.WriteLine("STUDY");
        Console.WriteLine("You stand in the study. There is a desk at the far end of the room with a locked drawer and" +
                          " a copper keyhole. There is a door to the west.");
        bool isInStudy = true;
        while (isInStudy == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move west")
            {
                goto case Room.SouthFoyer;
            } else if (userCommand == "move north")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "use copper key" && hasCopperKey == true)
            {
                drawerUnlocked = true;
                Console.WriteLine("You've opened the desk drawer. Inside is a screwdriver");
            } else if (userCommand == "take screwdriver" && drawerUnlocked == true)
            {
                hasScrewdriver = true;
                Console.WriteLine("You've taken the screwdriver.");
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.FirstBathroom:
        Console.WriteLine("FIRST FLOOR BATHROOM");
        Console.WriteLine("You stand in a bathroom. There is a door to the east.");
        bool isInFirstBathroom = true;
        while (isInFirstBathroom == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                goto case Room.NorthFoyer;
            } else if (userCommand == "move west")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move north")
            {
                Console.WriteLine("You can't go that way.");
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.GuestRoom:
        Console.WriteLine("GUEST ROOM");
        Console.WriteLine("You stand in the guest room. There is a door to the west.");
        bool isInGuestRoom = true;
        while (isInGuestRoom == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move west")
            {
                goto case Room.NorthFoyer;
            } else if (userCommand == "move north")
            {
                Console.WriteLine("You can't go that way.");
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.SecondLanding:
        Console.WriteLine("SECOND FLOOR LANDING");
        Console.WriteLine("You stand on the second floor landing. To the east is an open library. There are doors to" +
                          " the south and west. To the north are the stairs going down.");
        bool isInSecondLanding = true;
        while (isInSecondLanding == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                goto case Room.SecondBathroom;
            } else if (userCommand == "move east")
            {
                goto case Room.Library;
            } else if (userCommand == "move west")
            {
                goto case Room.BedroomNorth;
            } else if (userCommand == "move north")
            {
                goto case Room.NorthFoyer;
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.Library:
        Console.WriteLine("LIBRARY");
        Console.WriteLine("You stand in the library with shelves full of books. You notice a suspicious book that" +
                          " you are able to take.");
        bool isInLibrary = true;
        while (isInLibrary == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move west")
            {
                goto case Room.SecondLanding;
            } else if (userCommand == "move north")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "take suspicious book")
            {
                hasSuspiciousBook = true;
                Console.WriteLine("You've taken the suspicious book.");
            } else if (userCommand == "use suspicious book" && hasSuspiciousBook == true)
            {
                Console.WriteLine("The book had a secret compartment and inside" +
                                  " you find a copper key.");
                suspiciousBookOpen = true;
            } else if (userCommand == "take copper key" && suspiciousBookOpen == true)
            {
                Console.WriteLine("You've taken the copper key.");
                hasCopperKey = true;
            }else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.SecondBathroom:
        Console.WriteLine("SECOND FLOOR BATHROOM");
        Console.WriteLine("You stand in a bathroom. There are doors to the north and west.");
        bool isInSecondBathroom = true;
        while (isInSecondBathroom == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move west")
            {
                goto case Room.BedroomSouth;
            } else if (userCommand == "move north")
            {
                goto case Room.SecondLanding;
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.BedroomSouth:
        Console.WriteLine("BEDROOM SOUTH END");
        Console.WriteLine("You stand in the south end of the bedroom. To the north is the north end of the bedroom." +
                          " There is a door to the east.");
        bool isInBedroomSouth = true;
        while (isInBedroomSouth == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                goto case Room.SecondBathroom;
            } else if (userCommand == "move west")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move north")
            {
                goto case Room.BedroomNorth;
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.BedroomNorth:
        Console.WriteLine("BEDROOM NORTH END");
        Console.WriteLine("You stand in the north end of the bedroom. You notice a glint coming from beneath a floor" +
                          " board. You'd need a tool to pry it up. To the south is the south end of the bedroom." +
                          " There are doors to the east and north.");
        bool isInBedroomNorth = true;
        while (isInBedroomNorth == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                goto case Room.BedroomSouth;
            } else if (userCommand == "move east")
            {
                goto case Room.SecondLanding;
            } else if (userCommand == "move west")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move north")
            {
                goto case Room.BedroomCloset;
            } else if (userCommand == "use screwdriver" && hasScrewdriver == true)
            {
                floorboardUnlocked = true;
                Console.WriteLine("You've pried open the floorboard, inside you" +
                                  " find a gold key.");
            }else if (userCommand == "take gold key" && floorboardUnlocked == true)
            {
                Console.WriteLine("You've taken the gold key.");
                hasGoldKey = true;
            }
            else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.BedroomCloset:
        Console.WriteLine("BEDROOM CLOSET");
        Console.WriteLine("You stand in a closet. There is a door to the south.");
        bool isInBedroomCloset = true;
        while (isInBedroomCloset == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                goto case Room.BedroomNorth;
            } else if (userCommand == "move east")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move west")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move north")
            {
                Console.WriteLine("You can't go that way.");
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.BasementLanding:
        Console.WriteLine("BASEMENT LANDING");
        Console.WriteLine("You stand on the basement landing. To the south is an open lounge space. There are doors" +
                          " to the east and west. The door to west is locked with a gold keyhole. To the north are" +
                          " the stairs leading upstairs.");
        bool isInBasementLanding = true;
        while (isInBasementLanding == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                goto case Room.Lounge;
            } else if (userCommand == "move east")
            {
                goto case Room.Pantry;
            } else if (userCommand == "move west" && basementClosetUnlocked == false)
            {
                Console.WriteLine("The door is locked with a gold keyhole.");
            } else if (userCommand == "move north")
            {
                goto case Room.NorthFoyer;
            } else if (userCommand == "use gold key" && hasGoldKey == true)
            {
                basementClosetUnlocked = true;
                Console.WriteLine("You've unlocked the door.");
            } else if (userCommand == "move west" && basementClosetUnlocked == true)
            {
                goto case Room.BasementCloset;
            }
            else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.Pantry:
        Console.WriteLine("PANTRY");
        Console.WriteLine("You stand in the pantry. There is a door to the west.");
        bool isInPantry = true;
        while (isInPantry == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move west")
            {
                goto case Room.BasementLanding;
            } else if (userCommand == "move north")
            {
                Console.WriteLine("You can't go that way.");
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.Lounge:
        Console.WriteLine("LOUNGE SPACE");
        Console.WriteLine("You stand in the lounge. To the north is the basement landing.");
        bool isInLounge = true;
        while (isInLounge == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move west")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move north")
            {
                goto case Room.BasementLanding;
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.BasementCloset:
        Console.WriteLine("BASEMENT CLOSET");
        Console.WriteLine("You stand in a closet. There is a small door to the north.");
        bool isInBasementCloset = true;
        while (isInBasementCloset == true)
        {
            userCommand = Console.ReadLine().ToLower();
            if (userCommand == "move south")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move east")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move west")
            {
                Console.WriteLine("You can't go that way.");
            } else if (userCommand == "move north")
            {
                goto case Room.SecretRoom;
            } else
            {
                Console.WriteLine("I'm not sure what you mean.");
            }
        }
        break;
    case Room.SecretRoom:
        Console.WriteLine("HIDDEN ROOM");
        Console.WriteLine("You have found the hidden room, there is a small fortune in a chest." +
                          " Congratulations! You win.");
        Environment.Exit(0);
        break;
}


public enum Room
{
    Outside,
    SouthFoyer,
    NorthFoyer,
    Kitchen,
    Study,
    FirstBathroom,
    GuestRoom,
    SecondLanding,
    Library,
    SecondBathroom,
    BedroomSouth,
    BedroomNorth,
    BedroomCloset,
    BasementLanding,
    Pantry,
    Lounge,
    BasementCloset,
    SecretRoom
}