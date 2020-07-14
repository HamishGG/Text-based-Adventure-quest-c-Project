using System;
using System.Collections.Generic;

namespace AdventureGame
{
    class Game
    {
        Location currentLocation;

        public bool isRunning = true;
        private bool _gameOver;

        private List<Item> inventory;

        public Game()
        {
            inventory = new List<Item>();

            Console.WriteLine("Welcome  ");
            Console.WriteLine("Press 'h' or type 'help' for help");

            //Building the map

            Location l1 = new Location("Entrance",
                "entrance");
            Location l2 = new Location("hallway",
                "\n");
            Location l3 = new Location("room1",
                "\n");
            Location l4 = new Location("room2",
                "\n");
            Location l5 = new Location("room3",
                "\n");
            Location l6 = new Location("hallway2",
                "\n");
            Location l7 = new Location("room4",
                "\n");
            Location l8 = new Location("hallway3",
                "\n");
            Location l9 = new Location("\n",
                "\n");
            Location l10 = new Location("\n",
                "\n");
            Location l11 = new Location("\n",
                "\n");
            Location l12 = new Location("\n",
                "\n");
            Location l13 = new Location("\n",
                "\n");
            Location l14 = new Location("\n",
                "\n");
            Location l15 = new Location("\n",
                "\n");
            Location l16 = new Location("\n",
                "\n");
            Location l17 = new Location("\n",
                "\n");
            Location l18 = new Location("\n",
                "\n");
            Location l19 = new Location("\n",
                "\n");
            Location l20 = new Location("\n",
                "\n");
            Location l21 = new Location("\n",
                "\n");
            Location l22 = new Location("\n",
                "\n");
            Location l23 = new Location("\n",
                "\n");
            Location l24 = new Location("\n",
                "\n");
            Location l25 = new Location("\n",
                "\n");


            l1.addExit(new Exit(Exit.Directions.North, l2));

            l2.addExit(new Exit(Exit.Directions.North, l3));

            l3.addExit(new Exit(Exit.Directions.North,l6));
            l3.addExit(new Exit(Exit.Directions.East,l4));
            l3.addExit(new Exit(Exit.Directions.South,l2));
            l3.addExit(new Exit(Exit.Directions.West,l7));

            l4.addExit(new Exit(Exit.Directions.North,l5));
            l4.addExit(new Exit(Exit.Directions.West,l3));

            l5.addExit(new Exit(Exit.Directions.South, l4));
            l5.addExit(new Exit(Exit.Directions.West, l6));

            l6.addExit(new Exit(Exit.Directions.North, l8));
            l6.addExit(new Exit(Exit.Directions.East, l5));
            l6.addExit(new Exit(Exit.Directions.South, l3));

            l7.addExit(new Exit(Exit.Directions.North,l8));
            l7.addExit(new Exit(Exit.Directions.East,l3));
            l7.addExit(new Exit(Exit.Directions.West,l9));

            l8.addExit(new Exit(Exit.Directions.East, l7));
            l8.addExit(new Exit(Exit.Directions.West, l9));

            l9.addExit(new Exit(Exit.Directions.North, l10));
            l9.addExit(new Exit(Exit.Directions.East, l8));

            l10.addExit(new Exit(Exit.Directions.North, l11));
            l10.addExit(new Exit(Exit.Directions.East, l12));
            l10.addExit(new Exit(Exit.Directions.South, l9));

            l11.addExit(new Exit(Exit.Directions.East, l13));
            l11.addExit(new Exit(Exit.Directions.South, l10));
            l11.addExit(new Exit(Exit.Directions.West, l14));

            l12.addExit(new Exit(Exit.Directions.East, l8));
            l12.addExit(new Exit(Exit.Directions.West, l10));

            l13.addExit(new Exit(Exit.Directions.North, l15));
            l13.addExit(new Exit(Exit.Directions.East, l16));
            l13.addExit(new Exit(Exit.Directions.South, l6));
            l13.addExit(new Exit(Exit.Directions.West, l11));

            l14.addExit(new Exit(Exit.Directions.East, l11));

            l15.addExit(new Exit(Exit.Directions.North, l17));
            l15.addExit(new Exit(Exit.Directions.South, l13));

            l16.addExit(new Exit(Exit.Directions.West, l13));

            l17.addExit(new Exit(Exit.Directions.North, l18));
            l17.addExit(new Exit(Exit.Directions.East, l19));
            l17.addExit(new Exit(Exit.Directions.South, l15));
            l17.addExit(new Exit(Exit.Directions.West, l20));

            l18.addExit(new Exit(Exit.Directions.North, l21));
            l18.addExit(new Exit(Exit.Directions.South, l17));

            l19.addExit(new Exit(Exit.Directions.West,l17));

            l20.addExit(new Exit(Exit.Directions.East, l17));
            l20.addExit(new Exit(Exit.Directions.West, l22));

            l21.addExit(new Exit(Exit.Directions.East, l24));
            l21.addExit(new Exit(Exit.Directions.South, l18));

            l22.addExit(new Exit(Exit.Directions.North, l23));
            l22.addExit(new Exit(Exit.Directions.East, l20));

            l23.addExit(new Exit(Exit.Directions.South, l22));

            l24.addExit(new Exit(Exit.Directions.North, l25));
            l24.addExit(new Exit(Exit.Directions.West, l21));






            //Item food = new Item("rations", true, "A space ration. Not very tasty but is there any other option?");
            //l2.addItem(food);

            //l2.addExit(new Exit(Exit.Directions.East, l3));
            //l2.addExit(new Exit(Exit.Directions.West, l4));

            //l3.addExit(new Exit(Exit.Directions.South, l2));
            //l4.addExit(new Exit(Exit.Directions.South, l2));

            //Item spaceGun = new Item("space gun", true, "A gun that has been designed to be used in space combat");
            //Item ammo = new Item("space gun ammo", true,
            //    "Ammo for your Space Gun. 5.56mm rounds that where made by Elon Musks space team 'SpaceX'");
            //l1.addItem(spaceGun);
            //l1.addItem(ammo);

            currentLocation = l1;
            showLocation();
        }

        public void showLocation()
        {
            Console.WriteLine("\n" + currentLocation.getTitle() + "\n");
            Console.WriteLine(currentLocation.getDescrption());

            if (currentLocation.getInventory().Count > 0)
            {
                Console.WriteLine("\nThe room contains the following:\n");

                for (int i = 0; i < currentLocation.getInventory().Count; i++)
                {
                    Console.WriteLine(currentLocation.getInventory()[i].Name);
                }
            }

            Console.WriteLine("\nAvailable Exits: \n");

            foreach (Exit exit in currentLocation.getExits())
            {
                Console.WriteLine(exit.GetDirections());
            }

            Console.WriteLine();
        }

        //todo: Implement the input handling algorithm.

        public void doAction(string command)
        {
            //help command

            if (command == "help" || command == "h")
            {
                Console.WriteLine("Welcome to this Text Adventure!");
                Console.WriteLine("'l' / 'look':        Shows you the room, its exits, and any items it contains.");
                Console.WriteLine(
                    "'Look at X':         Gives you information about a specific item in your \n                     inventory, where X is the items name.");
                Console.WriteLine("'pick up X':         Attempts to pick up an item, where X is the items name.");
                Console.WriteLine("'use X':             Attempts to use an item, where X is the items name.");
                Console.WriteLine("'i' / 'inventory':   Allows you to see the items in your inventory.");
                Console.WriteLine("'q' / 'quit':        Quits the game.");
                Console.WriteLine();
                Console.WriteLine(
                    "Directions can be input as either the full word, or the abbriviation, \ne.g. 'North or N'");
                return;
            }

            if (command == "inventory" || command == "i")
            {
                showInventory();
                Console.WriteLine();
                return;
            }

            if (command.Length >= 7 && command.Substring(0, 7) == "pick up")
            {
                if (command == "pick up")
                {
                    Console.WriteLine("\nPlease specify what you would like to pick up\n");
                    return;
                }

                if (currentLocation.getInventory().Exists(x => x.Name == command.Substring(8)) &&
                    currentLocation.getInventory().Exists(x => x.Useable))
                {
                    inventory.Add(currentLocation.takeItem(command.Substring(8)));
                    Console.WriteLine("\nYou pick up the " + command.Substring(8) + ".\n");
                    return;
                }

                if (currentLocation.getInventory().Exists(x => x.Name == command.Substring(8)) &&
                    currentLocation.getInventory().Exists(x => x.Useable == false))
                {
                    Console.WriteLine("\nYou cannot pick up the " + command.Substring(8) + ".\n");
                    return;
                }

                Console.WriteLine("\n" + command.Substring(8) + " does not exist.\n");
                return;
            }

            if (command == "look" || command == "l")
            {
                showLocation();
                if (currentLocation.getInventory().Count == 0)
                {
                    Console.WriteLine("there are no items of interest in this room.\n");
                }
                return;
            }

            if (command.Length >= 7 && command.Substring(0, 7) == "look at")
            {
                if (command == "look at")
                {
                    Console.WriteLine("\n Please specify what you wish to look at.\n");
                    return;
                }

                if (currentLocation.getInventory().Exists(x =>
                    x.Name == command.Substring(8) || inventory.Exists(x => x.Name == command.ToLower().Substring(8))))
                {
                    if (command.Substring(8).ToLower() == "Space Gun")
                    {
                        Console.WriteLine("\n" + currentLocation.getInventory().Find(x => x.Name.Contains("Space Gun"))
                            .Descrption + "\n");
                        return;
                    }

                    if (command.Substring(8).ToLower() == "Space Gun Ammo")
                    {
                        Console.WriteLine("\n" + currentLocation.getInventory()
                            .Find(x => x.Name.Contains("Space Gun Ammo")).Descrption + "\n");
                        return;
                    }

                    if (command.Substring(8).ToLower() == "Rations")
                    {
                        Console.WriteLine("\n" + currentLocation.getInventory().Find(x => x.Name.Contains("Rations"))
                            .Descrption + "\n");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("\nThat item does not exist in this room or your inventory.\n");
                    return;
                }
            }

            if (command.Length >= 3 && command.Substring(0, 3) == "use")
            {
                if (command == "use")
                {
                    Console.WriteLine("\n Please specify what you wish to use.\n");
                    return;
                }

                if (inventory.Exists(x => x.Name == command.ToLower().Substring(4)))
                {
                    Console.WriteLine("\nUse " + command.Substring(4) + " with?\n");
                    string secondItem = Console.ReadLine();
                    if (currentLocation.getInventory().Exists(x => x.Name == secondItem))
                    {
                        if (secondItem == "me" && command.Substring(7) == "Rations")
                        {
                            Item emptyRations = new Item("Empty Rations", false, "An empty packet of rations.");
                            currentLocation.addItem(emptyRations);
                            foreach (Item item in currentLocation.getInventory())
                            {
                                if (item.Name.ToLower() == "Rations")
                                {
                                    currentLocation.removeItem(item);
                                    break;
                                }

                                if (item.Name.ToLower() == "me")
                                {
                                    break;
                                }

                            }

                            Console.WriteLine("You have eaten the rations and feel less hungry now");
                                return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("you cannot do this action");
                        return;
                    }
                }

                if (currentLocation.getInventory().Exists(x => x.Name == command.ToLower().Substring(4)))
                {
                    if (command.ToLower().Substring(4) == "body")
                    {
                        Console.WriteLine("\nThe body has been slashed across the chest and he is clearly dead");
                        return;
                    }

                    if (command.ToLower().Substring(4) == "game over")
                    {
                        Console.WriteLine("the game has came to an end");
                        _gameOver = true;
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("there is nothing to use");
                    return;
                }
            }

            if (moveRoom(command))
                return;

            Console.WriteLine("\nInvalid command, are you confused?\n");
            }

            private bool moveRoom(string command)
            {
                foreach (Exit exit in currentLocation.getExits())
                {
                    if (command == exit.ToString().ToLower() || command == exit.getShortDirection().ToLower())
                    {
                        currentLocation = exit.getLeadsTo();
                        Console.WriteLine("\nYou move " + exit.ToString() + " to the:\n");
                        showLocation();
                        return true;
                    }
                }
                return false;
            }


            private void showInventory()
            {
                if (inventory.Count > 0)
                {
                    Console.WriteLine("\nA quick look in your bag reveals the following:\n");

                    foreach (Item item in inventory)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
                else
                {
                    Console.WriteLine("\nYour bag is empty.\n");
                }
            }

            public void Update()
            {
                string currentCommand = Console.ReadLine().ToLower();

                // instantly check for a quit
                if (currentCommand == "quit" || currentCommand == "q")
                {
                    isRunning = false;
                    return;
                }


                if (!_gameOver)
                {
                    // otherwise, process commands.
                    doAction(currentCommand);
                }
                else
                {
                    Console.WriteLine("\nNope. Time to quit.\n");
                }
            }
        }
    }
