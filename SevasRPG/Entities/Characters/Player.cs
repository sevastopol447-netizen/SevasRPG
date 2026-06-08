using SevasRPG.Entities;
using SevasRPG.Entities.Characters;
using System;
using SevasRPG.Entities.Items;
using SevasRPG.Utils;

namespace SevasRPG.Entities.Characters
{
    public class Player : Character
    {
        private int _levelCup = 0;
        private int _expirience = 0;

        private int strength = 0;
        private int endurance = 0;
        private int agility = 0;
        private int intelligence = 0;
        private int criticalChance = 0;

        public ProgressBarValue MP = null;

        private Weapon weapon = null;
        private Armor armor = null;

        private int silver = 0;

        public int getSilver() => silver;
        public Weapon getWeapon() => weapon;
        public Armor getArmor() => armor;
        public int setSilver(int num) => silver += num;
        public Player(string name) : base(name, 1)
        {
            strength = 5;
            endurance = 5;
            agility = 4;
            intelligence = 8;

            criticalChance = (int)Math.Ceiling((double)agility * 0.5);
            this.createHpValue(endurance * 10);
            this.MP = new ProgressBarValue(intelligence * 5);
        }

        public void addExpirience(int value)
        {
            this._expirience += value;

            while (this._expirience > this._levelCup)
            {
                levelUp();
                this._expirience -= this._levelCup;
                this._levelCup = this._levelCup * 2;
            }
        }

        private void levelUp()
        {
            this._level += 1;

            MessageHelper.levelUpMessage(this._level);

            strength += 3;
            endurance += 3;
            agility += 2;
            intelligence += 4;

            criticalChance = (int)Math.Ceiling((double)agility * 0.5);
            this.createHpValue(endurance * 10);
            this.MP = new ProgressBarValue(intelligence * 5);
        }
    }
}