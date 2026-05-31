using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.Entities
{
    internal class Player
    {
        public string name;

        public int level;
        public int levelCap;

        public int intelligence;
        public int agility;
        public int experience;
        public int strength;
        public int endurance;
        public int visibility;

        public int healthPoints;
        public int maxHealthPoints;

        public int mana;
        public int maxMana;

        public int baseAttack;
        public int baseDeffense;

        public int silver;
        public string weaponName;
        public string armorName;
        public int critChance;

        public int CalculateAttackPower(int strength, int weaponDamage, int visibility)
        {
            return strength + weaponDamage + (visibility / 3);
        }
        public int CalculateDefense(int agility, int armorDefense, int visibility)
        {
            return agility + armorDefense + (visibility / 2);
        }
        public int CalculateCritChande(int agility, int visibility, int attack)
        {
            return agility + visibility - (attack / 5);
        }
    }
}
