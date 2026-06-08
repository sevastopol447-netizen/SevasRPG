using SevasRPG.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.Utils
{
    internal class WeaponGenerator
    {
        string[] typeNames = { "Меч", "Клинок", "Молот", "Спис", "Булава", "Мачете", "Палка", "Тризубець", "Сокира", "Шабля" };

        public Weapon createOne()
        {
            int damage = CustomRandomizer.generateNumber(1, 20);
            int price = damage * 15 + CustomRandomizer.generateNumber(-20, 70);

            if (price < 10) price = 10;

            return new Weapon(typeNames[CustomRandomizer.generateNumber(0, 9)], price, damage);
        }
        public List<Weapon> createMany(int num)
        {
            List<Weapon> shopItems = new List<Weapon>();
            for (int i = 0; i < num; i++)
            {
                shopItems.Add(createOne());
            }
            return shopItems; 
        }
    }
}
