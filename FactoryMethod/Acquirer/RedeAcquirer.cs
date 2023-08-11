using FactoryMethod.Enums;
using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Service
{
    internal class RedeAcquirer : IAcquirer
    {
        public EnumAcquirer Acquirer => EnumAcquirer.Rede;

        public RedeAcquirer()
        {
            Console.WriteLine("Adquirente Rede Criada com sucesso");
        }

        public void ReadFile()
        {
            Console.WriteLine("Lendo Arquivo Rede...");
        }
    }
}
