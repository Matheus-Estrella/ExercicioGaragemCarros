
using Controller;
using Models;

//Console.Write($"\nInsira o serviço para o veículo: ");
//string _serv = Console.ReadLine();
EntityService _service = new EntityService
{
    _id = 1,
    _description = "Limpeza",
    _status = false,
};

new GenController().Insert(_service);
