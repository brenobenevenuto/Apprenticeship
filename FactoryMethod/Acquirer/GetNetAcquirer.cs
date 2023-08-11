using FactoryMethod.Enums;
using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Service
{
    internal class GetNetAcquirer : IAcquirer
    {
        public EnumAcquirer Acquirer => EnumAcquirer.GetNet;

        public GetNetAcquirer() 
        {
            Console.WriteLine("Adquirente GetNet Criada com sucesso");
        }
        public void ReadFile()
        {
            Console.WriteLine("Lendo Arquivo GetNet...");
        }
    }
}
