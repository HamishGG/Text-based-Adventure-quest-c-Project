using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Monsters
    {
        private string monsterName;
        private string monsterDescription;
        private bool monsterDead;
        private int monsterHealth;
        private int monsterPower;
        private List<Location> locations;
        //init location information empty
        public Monsters()
        {
            monsterName = "";
            monsterDescription = "";
            monsterDead = false;
            monsterHealth = 25;
            monsterPower = 4;
            locations = new List<Location>();
        }

        //init location information with title
        public Monsters(string mName)
        {
            monsterName = mName;
            monsterDescription = "";
            locations = new List<Location>();
        }

        //init location information with title and desc
        
        public Monsters(string mName, string mDescrption)
        {
            monsterName = mName;
            monsterDescription = mDescrption;
            locations = new List<Location>();
        }

        public Monsters(string mName, string mDescrption,bool mDead, int mHealth, int mPower)
        {
            monsterName = mName;
            monsterDescription = mDescrption;
            monsterDead = mDead;
            monsterHealth = mHealth;
            monsterPower = mPower;

        }

        public Monsters(bool mDead)
        {
            monsterDead = mDead;
        }

        public override string ToString()
        {
            return monsterName;
        }
        public string getMonsterName()
        {
            return monsterName;
        }

        public void setMonster(string mName)
        {
             monsterName = mName;
        }

        public string getMonsterDescription()
        {
            return monsterDescription;
        }

        public void setMonsterDescription(string mDescription)
        {
             monsterDescription = mDescription;
        }

        public bool getMonsterDead()
        {
            return monsterDead;
        }

        public void setMonsterDead(bool mDead)
        {
            monsterDead = mDead;
        }

        public int getMonsterHealth()
        {
            return monsterHealth;
        }

        public void setMonsterHealth(int mHealth)
        {
            monsterHealth = mHealth;
        }

        public int getMonsterPower()
        {
            return monsterPower;
        }

        public void setMonsterPower(int mPower)
        {
            monsterPower = mPower;
        }


    }
    }
