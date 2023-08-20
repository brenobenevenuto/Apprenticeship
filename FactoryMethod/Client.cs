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
            //Instancia a "Fabrica".
            var selectAcquirer = new SelectAcquirer();


            while (true) 
            {

                Console.WriteLine("Selecione a Adquirente");
                Console.WriteLine("1 - Cielo");
                Console.WriteLine("2 - Rede");
                Console.WriteLine("3 - GetNet");
                //Recebe o valor da adquirente selecionada.
                var typeAcquirer = int.Parse(Console.ReadLine());
                //Passa a adquirente para a "fabrica" retornar a instancia correta.
                var acquirerService = selectAcquirer.CreateAcquirer((EnumAcquirer)typeAcquirer);
                //Realiza a instrução de leitura de arquivo, metodo de que todas as adquirentes cadastrada na fabrica contem.
                acquirerService.ReadFile();
            }
        }
    }  
}
