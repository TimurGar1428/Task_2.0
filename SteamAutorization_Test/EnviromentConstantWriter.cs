using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SteamAutorization_Test
{
    internal class EnviromentConstantWriter
    {
       public void WriteDown()
        {
            var enviromentConstants = new EnviromentConstants();
            string objectSerialized = JsonSerializer.Serialize(enviromentConstants);
            File.WriteAllText("Game_Data.json",objectSerialized);
        }
        
    }
}
