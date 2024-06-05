using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ReadFile
    {
        public static List<Generic> GetData()
        {
            Generic gen = new Generic();
            string path = gen.GetPath();
            string file = gen.GetFile();

            if (!File.Exists(path+file))
            {
                throw new FileNotFoundException($"O arquivo '{file}' não foi encontrado no diretório '{path}'.");
            }

            string jsonContent = File.ReadAllText(path + file);

            List<Generic> lista = JsonConvert.DeserializeObject<List<Generic>>(jsonContent);

            return lista;
        }
    }
}
