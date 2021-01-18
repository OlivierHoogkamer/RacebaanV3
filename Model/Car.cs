using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Car : IEquipment
    {
        public int Quality { get; set; }
        public int Performance { get; set; }
        public int Speed { get; set; }
        public bool IsBroken { get; set; }

        public Car (int _quality, int _performance, int _speed, bool _isbroken)
        {
            Quality = _quality;
            Performance = _performance;
            Speed = _speed;
            IsBroken = _isbroken;
        }
    }
}
