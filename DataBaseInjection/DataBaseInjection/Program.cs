using Controller;
using Models;

DB_CarInject();

static void DB_CarInject()
{
    var lst = ReadFile.GetData<Car>();
    Car generic = new Car();
    string _tableName = generic.GetTableName();
    int count = 1;
    foreach (var car in lst)
    {
        if (new GenController().Insert(car, _tableName))
        {
            Console.WriteLine($"[{count}º] Veículo Adicionado !!!");
        }
        else
        {
            Console.WriteLine($"[{count}º] Erro ao adicionar veículo  !!!");
        }
        count++;
    }
}