using SevasRPG.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.GameServices.Events
{
    internal class Lost
    {
        public string Description = "Ти раптом зрозумів що загубив дещо!";
        public Action<Player> ApplyEffect;
    }
}
