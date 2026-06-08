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
    internal class FoundSkillBook : Event
    {
        public FoundSkillBook() : base("Щаслива знахідка", "Ти собі ідеш і помічаєш на дорозі лежить забута книжка.")
        { }

        public override void execute(Player player)
        {
            int percent = CustomRandomizer.generateNumber(1, 100);

            if (percent <= 25)
            {
                player.addStrength(CustomRandomizer.generateNumber(1, 3));
            } 
            else if (percent <= 50)
            {

            }
            else if (percent <= 75)
            {

            } 
            else
            {

            }
        }
    }
}
