using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EntityService : Generic
    {
        readonly string path = @"C:\Users\Matheus\Exercicios_Estagio\ExericioGaragemCarros\CarGenerator";
        readonly string file = @"\Vehicles.json";
        readonly string _tableName = "TB_Garagem";
        readonly string _inforRestrained = "_id";

        public int _id { get; set; }
        public string _description { get; set; }
        public bool _status { get; set; }

        public override string GetPath() { return path; }
        public override string GetFile() { return file; }
        public override string GetTableName() { return _tableName; }
        public override string GetRestrained() { return _inforRestrained; }
    }
}
