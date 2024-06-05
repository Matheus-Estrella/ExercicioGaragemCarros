using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGenerator
{
    public class Car
    {
        public string _licensePlate { get; set; }
        public string _name { get; set; }
        public int _modelYear { get; set; }
        public int _makedYear { get; set; }
        public string _color { get; set; }

        public Car(string licensePlate, string name, int modelYear, int makedYear, string collor)
        {
            _licensePlate = licensePlate;
            _name = name;
            _modelYear = modelYear;
            _makedYear = makedYear;
            _color = collor;
        }
    }
}
