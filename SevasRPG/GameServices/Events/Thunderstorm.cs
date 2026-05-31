using SevasRPG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.GameServices.Events
{
    internal class Thunderstorm
    {
        public string Description = "Дощ переріс у зливу! Тепер взагалі нічого не видно!";
        public Action<Player> ApplyEffect;
    }
}
