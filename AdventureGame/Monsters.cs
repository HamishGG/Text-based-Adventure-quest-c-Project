using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Monsters
    {
        private string monsterName;
        private string monsterDescription;
        private int monsterHealth;
        private int monsterAttackDamage;
        private bool monsterDead;

        public Monsters(string _monsterName, string _monsterDescription, int _monsterHealth, int _monsterAttackDamage)
        {
            monsterName = _monsterName;
            monsterDescription = _monsterDescription;
            monsterHealth = _monsterHealth;
            monsterAttackDamage = _monsterAttackDamage;
        }

        public string MonsterName { get; set; }

        public string MonsterDescription { get; set; }

        public int MonsterHealth { get; set; }

        public int MonsterAttackDamage
        {
            get;
            set;
        }
    }
}
