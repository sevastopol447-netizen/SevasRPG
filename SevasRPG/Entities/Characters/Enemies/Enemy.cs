using SevasRPG.Entities.Characters;
using SevasRPG.Entities.Items;
using SevasRPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.Entities.Characters.Enemies
{
    public class Enemy : Character
    {
        private int attack = 0;
        private int defence = 0;

        private int rewardsilver = 0;
        private int rewardXp = 0;

        private int generateValue(int step, int minModifier, int maxModifier)
        {
            return this._level * step + CustomRandomizer.generateNumber(minModifier, maxModifier);
        }

        public Enemy(string name, int level) : base(name, level)
        {
            this.attack = generateValue(10, -10, 10);
            this.defence = generateValue(12, -10, 10);

            this.rewardsilver = generateValue(100, -20, 50);
            this.rewardXp = generateValue(50, -10, 50);
        }

        public int Attack() => attack;
        public int getDefence() => defence;
        public int getRewardsilver() => rewardsilver;
        public int getRewardXp() => rewardXp;

        public bool takeDamage(int dmg)
        {
            return (HP.decrease(dmg - defence));
        }
    }
}