using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Player
    {
        private string playerName;
        private int playerHealth;
        private List<Item> inventory;
        private bool isDead;

        public Player()
        {
            playerName = "";
            playerHealth = 100;
            inventory = new List<Item>();
            isDead = false;
        }


        public string getName(string Prompt)
        {
            string nplayerName = "";
            do {
                Console.Write(Prompt + ": ");
                nplayerName = Console.ReadLine();
                if (string.IsNullOrEmpty(nplayerName)) {
                    Console.WriteLine("Empty input, please try again");
                }
            } while (string.IsNullOrEmpty(nplayerName));
            return nplayerName;
        }

        public void setName(string nplayerName)
        {
            playerName = nplayerName;
        }

        public int getHealth()
        {
            return playerHealth;
        }


        public void setHealth(int _pHealth)
        {
            playerHealth = _pHealth;
        }

        public bool getdeath()
        {
            return isDead;
        }
        public bool SetisDead(bool death)
        {
            isDead = death;
            return isDead;
        }



    }
}
