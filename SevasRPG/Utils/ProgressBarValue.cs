using System;

namespace SevasRPG.Utils
{
    public class ProgressBarValue
    {
        private int _minimum = 0;
        private int _maximum = 100;
        private int _value = 0;

        public ProgressBarValue(int max, int min = 0)
        {
            init(max, min);
        }

        public void init(int max, int min = 0)
        {
            this._minimum = min;
            this._maximum = this._value = max;
        }

        public void increase(int value)
        {
            if (this._value + value > this._maximum)
                this._value = this._maximum;
            else
                this._value += value;
        }

        public bool decrease(int value)
        {
            if (this._value - value <= this._minimum)
            {
                this._value = this._minimum;
                return false;
            }
            else
            {
                this._value -= value;
                return true;
            }
        }
    }
}