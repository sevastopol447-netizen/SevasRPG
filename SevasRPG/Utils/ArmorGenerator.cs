using SevasRPG.Entities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.Utils
{
    internal class ArmorGenerator
    {
        string[] typeNames = { "Нагрудник", "Шолом", "Кольчуга", "Чоботи", "Броня", "Щит" };

        public Armor createOne()
        {
            int armor = CustomRandomizer.generateNumber(1, 20);
            int price = armor * 15 + CustomRandomizer.generateNumber(-20, 60);

            if (price < 10) price = 10;

            return new Armor(typeNames[CustomRandomizer.generateNumber(0, 5)], price, armor);
        }
        public List<Armor> createMany(int num)
        {
            List<Armor> shopItems = new List<Armor>();
            for (int i = 0; i < num; i++)
            {
                shopItems.Add(createOne());
            }
            return shopItems;
        }
    }
}
