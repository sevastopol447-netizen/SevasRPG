using System;

namespace SevasRPG.Entities.Items
{
    public class Weapon : Item
    {
        public Weapon(string name, int price, int value) : base(name, price, value)
        {
        }

        public int getVal() => this._value;
    }
}