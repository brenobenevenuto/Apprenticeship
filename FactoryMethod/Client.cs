using FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Client
    {

        public void ExecutarCriacaoAcquirer() 
        {
            var client = new SelectAcquirer();

            while (true) 
            {
                Console.WriteLine("Selecione a Adquirente");
                Console.WriteLine("1 - Cielo");
                Console.WriteLine("2 - Rede");
                Console.WriteLine("3 - GetNet");
                var typeAcquirer = int.Parse(Console.ReadLine());

                var acquirerService = client.CreateAcquirer((EnumAcquirer)typeAcquirer);

                acquirerService.ReadFile();
            }
        }
    }  
}
