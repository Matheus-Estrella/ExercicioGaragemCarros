﻿using Models;
using Service;

namespace Controller
{
    public class GenController
    {
        private GenService _GenService;

        public GenController()
        {
            _GenService = new GenService();
        }
        public bool Insert(Generic generic, string _tableName)
        {
            return _GenService.Insert(generic,_tableName);
        }
    }
}
