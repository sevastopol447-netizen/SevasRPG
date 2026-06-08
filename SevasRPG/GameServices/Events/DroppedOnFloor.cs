using SevasRPG.Entities;
using SevasRPG.Entities.Characters;
using SevasRPG.Entities.Items;
using SevasRPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevasRPG.GameServices.Events
{
    public class DroppedOnFloor : Event
    {
        public DroppedOnFloor() : base("Щаслива знахідка", "Ти ідеш собі і бачиш на дорозі цінне щось лежить.")
        {}

        public override void execute(Player player)
        {
            int percent = CustomRandomizer.generateNumber(1, 100);
            if (percent <= 90)
            {
                player.setSilver(CustomRandomizer.generateNumber(50, 300));
            } 
            else if (percent > 90 && percent <= 95)
            {
                Weapon weapon = (new WeaponGenerator()).createOne();

                string text = $"Під каменюкою ви побачили нову зброю {weapon.getName()} яка має {weapon.getVal()} шкоди. ";

                if (player.getWeapon() == null)
                    text += "У вас в руках зброї немає";
                else
                    text += $"Ваша зброя - {player.getWeapon().getName()} та має шкоди {player.getWeapon().getVal()}.";

                text += "Чи хочете замінити свою зброю?";

                DialogResult dialogResult = MessageBox.Show("Повідомлення", text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.OK)
                {
                    player.setWeapon(weapon);
                }

            } else
            {

            }
        }
    }
}
