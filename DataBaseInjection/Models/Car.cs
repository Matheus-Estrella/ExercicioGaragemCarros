using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car
    {
        readonly string path = @"C:\Users\Matheus\Exercicios_Estagio\ExericioGaragemCarros\CarGenerator";
        readonly string file = @"\Vehicles.json";
        readonly string _tableName = "TB_Garagem";

        public string _licencePlate {  get; set; }
        public string _name { get; set; }
        public int _modelYear { get; set; }
        public int _makedYear { get; set; }
        public string _collor { get; set; }


        public string GetPath() { return path; }
        public string GetFile() { return file; }
        public string GetTableName() { return _tableName; }

    }
}
