using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car : Generic
    {
        readonly string path = @"C:\Users\Matheus\Exercicios_Estagio\ExericioGaragemCarros\CarGenerator";
        readonly string file = @"\Vehicles.json";
        readonly string _tableName = "TB_Garagem";
        readonly string _inforRestrained = "";

        public string _licensePlate {  get; set; }
        public string _name { get; set; }
        public int _modelYear { get; set; }
        public int _makedYear { get; set; }
        public string _color { get; set; }

        public override string GetPath() { return path; }
        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }

    }
}
