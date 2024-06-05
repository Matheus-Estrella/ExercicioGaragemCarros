using Controller;
using Models;

var lst = ReadFile.GetData();
Generic generic = new Generic();
string _tableName = generic.GetTableName();
int count = 1;
foreach (var car in lst)
{
    if (new GenController().Insert(car,_tableName))
    {
        Console.WriteLine($"[{count}º] Veículo Adicionado !!!");
    }
    else
    {
        Console.WriteLine($"[{count}º] Erro ao adicionar veículo  !!!");
    }
    count++;
}