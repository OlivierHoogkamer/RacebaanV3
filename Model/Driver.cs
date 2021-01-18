using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Driver : IParticipant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public IEquipment Equipment { get; set; }
        public TeamColors TeamColor {get; set;}
        public Car car { get; set; }
        // default equipment
        
        public Driver (string _name, int _points, TeamColors _teamcolor)
        {
            //default car
            Car c = new Car(100, 100, 100, false);
            Name = _name;
            Points = _points;
            Equipment = c;
            TeamColor = _teamcolor;

        }
    }
}
