﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace AdventureGame
{
    class Game
    {
        Location currentLocation;
        public bool isRunning = true;
        private bool _gameOver;
        public readonly string Url = "https://hamishgalpin.com/AdventureImages/Map.jpg";



        private List<Item> inventory;
        readonly Player player = new Player();
        private List<Monsters> monsters;



        public Game()
        {

            inventory = new List<Item>();
            var textInfo = new CultureInfo("en-UK", false).TextInfo;
            var result = textInfo.ToTitleCase(player.getName("Please enter the name you would to be called"));
            Console.Clear();
            Console.WriteLine("\nHello and welcome to Europa Moon base. {0} as you can see there is clearly a problem here.\nWe would like you to check the place out ",result);
            Console.WriteLine("\nPress 'h' or type 'help' for help");
            Console.WriteLine("\nIf you would like to see a photo of the map please type in 'map' or 'm'. THIS WILL OPEN IN DEFAULT BROWSER");
            doAction("help");
            Console.WriteLine("\nYour current health is: {0}", player.getHealth());

            //Building the map

            Location l1 = new Location("l1entrance",
                "entrance");
            Location l2 = new Location("l2hallway",
                "\n");
            Location l3 = new Location("l3room",
                "\n");
            Location l4 = new Location("l4room",
                "\n");
            Location l5 = new Location("l5room",
                "\n");
            Location l6 = new Location("l6hallway",
                "\n");
            Location l7 = new Location("l7room",
                "\n");
            Location l8 = new Location("l8hallway",
                "\n");
            Location l9 = new Location("l9hallway",
                "\n");
            Location l10 = new Location("l10room",
                "\n");
            Location l11 = new Location("l11hallway",
                "\n");
            Location l12 = new Location("l12hallway",
                "\n");
            Location l13 = new Location("l13hallway",
                "\n");
            Location l14 = new Location("l14room",
                "\n");
            Location l15 = new Location("l15room",
                "\n");
            Location l16 = new Location("l16hallway",
                "\n");
            Location l17 = new Location("l17hallway",
                "\n");
            Location l18 = new Location("l18room",
                "\n");
            Location l19 = new Location("l19hallway",
                "\n");
            Location l20 = new Location("l20hallway",
                "\n");
            Location l21 = new Location("l21room",
                "\n");
            Location l22 = new Location("l22room",
                "\n");
            Location l23 = new Location("l23hallway",
                "\n");
            Location l24 = new Location("l24room",
                "\n");
            Location l25 = new Location("l15hallway",
                "\n");
            Location l26 = new Location("l26bossroom",
                "\n");

            //directions
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

            l6.addExit(new Exit(Exit.Directions.North, l15));
            l6.addExit(new Exit(Exit.Directions.East, l5));
            l6.addExit(new Exit(Exit.Directions.South, l3));

            l7.addExit(new Exit(Exit.Directions.North,l8));
            l7.addExit(new Exit(Exit.Directions.East,l3));
            l7.addExit(new Exit(Exit.Directions.West,l9));

            l8.addExit(new Exit(Exit.Directions.South, l7));
            l8.addExit(new Exit(Exit.Directions.West, l12));

            l9.addExit(new Exit(Exit.Directions.East, l7));
            l9.addExit(new Exit(Exit.Directions.West, l10));

            l10.addExit(new Exit(Exit.Directions.North, l11));
            l10.addExit(new Exit(Exit.Directions.East, l9));

            l11.addExit(new Exit(Exit.Directions.North, l13));
            l11.addExit(new Exit(Exit.Directions.East, l12));
            l11.addExit(new Exit(Exit.Directions.South, l10));

            l12.addExit(new Exit(Exit.Directions.East, l8));
            l12.addExit(new Exit(Exit.Directions.West, l11));

            l13.addExit(new Exit(Exit.Directions.East, l15));
            l13.addExit(new Exit(Exit.Directions.South, l11));
            l13.addExit(new Exit(Exit.Directions.West, l14));

            l14.addExit(new Exit(Exit.Directions.East, l13));

            l15.addExit(new Exit(Exit.Directions.North, l17));
            l15.addExit(new Exit(Exit.Directions.East, l16));
            l15.addExit(new Exit(Exit.Directions.South, l6));
            l15.addExit(new Exit(Exit.Directions.West, l13));

            l16.addExit(new Exit(Exit.Directions.West, l15));

            l17.addExit(new Exit(Exit.Directions.North, l18));
            l17.addExit(new Exit(Exit.Directions.South, l15));

            l18.addExit(new Exit(Exit.Directions.North, l23));
            l18.addExit(new Exit(Exit.Directions.East, l19));
            l18.addExit(new Exit(Exit.Directions.South, l17));
            l18.addExit(new Exit(Exit.Directions.West,l20));

            l19.addExit(new Exit(Exit.Directions.West,l18));

            l20.addExit(new Exit(Exit.Directions.East, l18));
            l20.addExit(new Exit(Exit.Directions.West, l21));

            l21.addExit(new Exit(Exit.Directions.North, l22));
            l21.addExit(new Exit(Exit.Directions.East, l20));

            l22.addExit(new Exit(Exit.Directions.South, l21));

            l23.addExit(new Exit(Exit.Directions.North, l24));
            l23.addExit(new Exit(Exit.Directions.South, l18));

            l24.addExit(new Exit(Exit.Directions.East, l25));
            l24.addExit(new Exit(Exit.Directions.South, l23));

            l25.addExit(new Exit(Exit.Directions.North,l26));
            l25.addExit(new Exit(Exit.Directions.East,l24));
            //directions end


            l3.addMonster(new Monsters("Ghaak", "I horrible looking beast that is covered in blood.", false, 15, 4));
            l5.addMonster(new Monsters("Chesuns","Their skin is elastic and strong. It's covered in a thick layer of mucous.",false,20,3));
            l7.addMonster(new Monsters("Ghaulqud","These aliens are a type of amphibian. They have six arms and two legs, with a short, powerful tail.",false,25,2));
            l10.addMonster(new Monsters("Breerrix","Their skin colors are mostly dark red, dark gold, dark bronze, white and dark pink, ",false,15,7));
            l11.addMonster(new Monsters("Viegas","Their skin is elastic and strong. It's covered in small, coarse scales",false,10,1));
            l13.addMonster(new Monsters("Viegas","Their skin is elastic and strong. It's covered in small, coarse scales",false,20,3));
            l14.addMonster(new Monsters("Kholzen","These aliens are a type of amphibian. They have four arms and four legs, with a short, thin tail.",false,30,2));
            l16.addMonster(new Monsters("Eciel","Their ears are small and stubby and their hearing is excellent.",false,35,7));
            l17.addMonster(new Monsters("Viegas","Their skin is elastic and strong. It's covered in small, coarse scales",false,10,2));
            l18.addMonster(new Monsters("Vrekon","Their scale colors are mostly brown, red and light red, which tend to become dim as they age.",false,15,3));
            l19.addMonster(new Monsters("Crol","Their long mouths and wide noses often make these aliens appear to be reserved, but looks can be deceiving.",false,25,5));
            l22.addMonster(new Monsters("Xuuk","Their ears are huge and their hearing is not the best. They also have two horns on their heads.",false,25,6));
            l20.addMonster(new Monsters("Vrigoids","Their skin is very thick and rough. It's covered short, curly hairs.",false,30,3));
            l24.addMonster(new Monsters("Ferruk","These aliens are a type of mammal. They have four arms and two legs, with a long, thin tail.",false,25,10));
            l25.addMonster(new Monsters("Nihilanth","Physically, the Nihilanth resembles a gigantic, \nabnormally proportioned brownish-gray (pink in some lighting instances) fetus with a massive head atop a smaller body",false,55,9));

            Item healItem = new Item("healthpack", true, "+10 Health");

            l3.addItem(healItem);

            currentLocation = l1;
            showLocation();
        }

        public void showLocation()
        {
            Console.WriteLine("\nlocation: " + currentLocation.getTitle() + "\n");
            Console.WriteLine("What you see: " + currentLocation.getDescrption());

            if (currentLocation.getInventory().Count > 0)
            {
                Console.WriteLine("\nThe room contains the following:\n");

                for (int i = 0; i < currentLocation.getInventory().Count; i++)
                {
                    Console.WriteLine(currentLocation.getInventory()[i].Name);
                }
            }

            Console.WriteLine("\nAvailable Exits:");

            foreach (Exit exit in currentLocation.getExits())
            {
                Console.WriteLine(exit.GetDirections() + "\n");
            }

            foreach (Monsters monster in currentLocation.getMonsters())
            {
                Console.WriteLine("\nA monster has been found in the room: \nName: {0} \nDescription: {1}" +
                                  " \nHealth: {2} \nPower: {3}", monster.getMonsterName(),
                    monster.getMonsterDescription(), monster.getMonsterHealth(), monster.getMonsterPower());
            }

            Console.WriteLine("Please enter next command: ");
        }


        //    var commandline = new List<string>();
        //    var commandString = "";

        //    if (currentLocation.getInventory().Count == 1)
        //    {
        //        var haveitems = "u";
        //        commandline.Add(haveitems);
        //    }

        //    if (currentLocation.getMonsters().Count == 1)
        //    {
        //        var havemonsters = "a";
        //        commandline.Add(havemonsters);
        //    }

        //    commandString = "\tpossible commands " + string.Join(" ", commandline);

        //    Console.WriteLine("Please enter next command: " + commandString);
        //}




        //todo: Implement the input handling algorithm.

            public void doAction(string command)
            {
                //help command

                if (command == "help" || command == "h")
                {
                    Console.WriteLine("Welcome to this Text Adventure!");
                    //Console.WriteLine("'l' / 'look':        Shows you the room, its exits, and any items it contains.");
                    //Console.WriteLine(
                    //"'Look at X':         Gives you information about a specific item in your \n                     inventory, where X is the items name.");
                    Console.WriteLine("'pickup X':         Attempts to pick up an item, where X is the items name.");
                    //Console.WriteLine("'use X':             Attempts to use an item, where X is the items name.");
                    //Console.WriteLine("'i' / 'inventory':   Allows you to see the items in your inventory.");
                    Console.WriteLine("'q' / 'quit':        Quits the game.");
                    Console.WriteLine("'m' / 'map':         Opens a copy of the map in your browser");
                    Console.WriteLine("'d' / 'die':         This will kill you and end the game.(for testing purposes)");
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

                if (command == "map" || command == "m")
                {
                    OpenUrl(Url);
                    return;
                }

                if (command.Length >= 1 && command.Substring(0, 1) == "p")
                {
                    if (command == "pickup")
                    {
                        Console.WriteLine("\nPlease specify what you would like to pick up\n");
                        return;
                    }
                    if (currentLocation.getInventory().Exists(x => x.Name == command.Substring(2)) &&
                        currentLocation.getInventory().Exists(x => x.Useable))
                    {
                        inventory.Add(currentLocation.takeItem(command.Substring(2)));
                        Console.WriteLine("\nYou pick up the " + command.Substring(2) + ".\n");
                        return;
                    }

                    if (currentLocation.getInventory().Exists(x => x.Name == command.Substring(2)) &&
                        currentLocation.getInventory().Exists(x => x.Useable == false))
                    {
                        Console.WriteLine("\nYou cannot pick up the " + command.Substring(2) + ".\n");
                        return;
                    }

                    Console.WriteLine("\n" + command.Substring(2) + " does not exist.\n");
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
                        Console.WriteLine("\nPlease specify what you wish to look at.\n");
                        return;
                    }
                    if (currentLocation.getInventory().Exists(x => x.Name == command.Substring(8)) || inventory.Exists(x => x.Name == command.ToLower().Substring(8)))
                    {
                        if (command.Substring(8).ToLower() == "healthpack")
                        {
                            Console.WriteLine("\n" + currentLocation.getInventory().Find(x => x.Name.Contains("healthpack")).Description + "\n");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThat item does not exist in this location or your inventory.\n");
                        return;
                    }
                }


                if (command == "d" || command == "die")
                {
                    player.setHealth(0);
                    pHealthGone();
                    return;
                }

                if (command == "a" || command == "attack")
                {
                    attack();
                    return;
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
                        if (currentLocation.getMonsters().Count == 1)
                        {
                            Console.WriteLine("You cannot move room till you have killed the enemy.");
                            return false;
                        }
                        currentLocation = exit.getLeadsTo();
                        Console.WriteLine("\nYou move " + exit.ToString() + " to the:\n");
                        showLocation();
                        return true;
                    }
                }
                return false;
            }

            private void pHealthGone()
            {
                if (player.getHealth() == 0 || player.getdeath())
                {
                    Console.WriteLine("I'm Afraid you have died and this is game over :(");
                    player.SetisDead(true);
                    isRunning = false;
                }
            }

            private void attack()
            { 
                if (currentLocation.getMonsters().Count == 1)
                {
                    foreach (Monsters monster in currentLocation.getMonsters())
                    {
                        Random rnd = new Random();
                        var monsterHealth = monster.getMonsterHealth();
                        int updatedMHealth;
                        var playerHealth = player.getHealth();
                        int updatePHealth;
                        int damageChance = rnd.Next(1, 15);


                        if (monster.getMonsterHealth() == 0)
                        {
                            monster.setMonsterDead(true);
                            Console.WriteLine("The monster is dead and you can no longer attack it.");
                            return;
                        }

                        if (damageChance == 3 || damageChance == 5)
                        {
                            Console.WriteLine("Oh No you missed and did not deal damage");
                            updatePHealth = playerHealth - monster.getMonsterPower();
                            player.setHealth(updatePHealth);
                            Console.WriteLine("Due top you missing the monster deals {0} damage.", monster.getMonsterPower());
                            Console.WriteLine("Your health is now {0}.", player.getHealth());
                            pHealthGone();
                            return;
                        }

                        if (damageChance == 9)
                        {
                            updatedMHealth = monsterHealth - 10;
                            monster.setMonsterHealth(updatedMHealth);
                            Console.WriteLine("CRITICAL!! You shoot the monster dealing 10 Damage.");
                            if (updatedMHealth <= -0)
                            {
                                Console.WriteLine("You have killed the monster from the critical shot.");
                                Console.WriteLine("the monster has been killed. You may move to the next room");
                                currentLocation.removeMonster(monster);
                                pShowHealth();
                                showLocation();

                                
                            }
                            else
                            {
                                Console.WriteLine("The monsters health is now {0}.", monster.getMonsterHealth());   
                                return;
                            }
                            Console.WriteLine("Your health is now {0}.", player.getHealth());
                            return;
                        }

                        updatedMHealth = monsterHealth - 5;
                        monster.setMonsterHealth(updatedMHealth);
                        Console.WriteLine("You shoot the monster dealing 5 Damage.");                         
                        if (monster.getMonsterHealth()  > 0)
                        {
                            Console.WriteLine("The monsters health is now {0}.", monster.getMonsterHealth());

                        }
                        else
                        {
                            Console.WriteLine("the monster has been killed. You may move to the next room");
                            currentLocation.removeMonster(monster);
                            pShowHealth();
                            showLocation();
                            return;
                        }
                        updatePHealth = playerHealth - monster.getMonsterPower();
                        player.setHealth(updatePHealth);
                        Console.WriteLine("When attacking the monster they dealt {0} damage.",monster.getMonsterPower());
                        Console.WriteLine("Your health is now {0}.", player.getHealth());
                        pHealthGone();
                        return;
                    }
                }

            }

            private void pShowHealth()
            {
                Console.WriteLine("\nyour current health is: {0}\n", player.getHealth());
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

            private void OpenUrl(string url)
            {
                try
                {
                    Process.Start(url);
                }
                catch
                {
                    // hack because of this: https://github.com/dotnet/corefx/issues/10361
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        url = url.Replace("&", "^&");
                        Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        Process.Start("xdg-open", url);
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        Process.Start("open", url);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }
}
