using SevasRPG.Entities.Characters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevasRPG.GameServices.Events
{
    public abstract class Event
    {
        int id = 0;
        static int autoInc = 1;
        protected string name = "";
        protected string description = "";

        protected Event(string name, string desc) {
            this.name = name;
            this.description = desc;
            this.id = autoInc++;
        }

        public int getId() => id;
        public string getName() => name;
        public string getDescription() => description;

        public abstract void execute(Player player);
    }
}
