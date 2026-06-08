using SevasRPG.Entities;
using SevasRPG.Entities.Characters;
using SevasRPG.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.GameServices.Events
{
    internal class Lost : Event
    {
        public Lost() : base("Бідося!", "Ти раптом зрозумів що загубив грошенята!")
        { }

        public override void execute(Player player)
        {
            int value = CustomRandomizer.generateNumber(1, 200);

            if (player.getSilver() < value)
            {
                player.setSilver(0);
            } else
            {
                player.decreaseSilver(value);
            }
        }
    }
}
