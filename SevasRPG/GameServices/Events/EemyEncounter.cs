using SevasRPG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.GameServices.Events
{
    internal class EemyEncounter
    {
        public string Description = "Зза повороту на тебе вистрибує ворог!!!";
        public Action<Player> ApplyEffect;
    }
}
