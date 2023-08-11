using FactoryMethod.Enums;
using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Service
{
    internal class CieloAcquirer : IAcquirer
    {
        public EnumAcquirer Acquirer => EnumAcquirer.Cielo;

        public CieloAcquirer() 
        {
            Console.WriteLine("Adquirente Cielo Criada com sucesso");
        }
        public void ReadFile()
        {
            Console.WriteLine("Lendo Arquivo Cielo...");
        }
    }
}
