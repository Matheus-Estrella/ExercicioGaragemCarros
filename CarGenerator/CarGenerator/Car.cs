using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGenerator
{
    public class Car
    {
        public string _licencePlate { get; set; }
        public string _name { get; set; }
        public int _modelYear { get; set; }
        public int _makedYear { get; set; }
        public string _collor { get; set; }

        public Car(string licencePlate, string name, int modelYear, int makedYear, string collor)
        {
            _licencePlate = licencePlate;
            _name = name;
            _modelYear = modelYear;
            _makedYear = makedYear;
            _collor = collor;
        }
    }
}
